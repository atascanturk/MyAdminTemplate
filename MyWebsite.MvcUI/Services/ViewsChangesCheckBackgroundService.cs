using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using MyWebsite.Business.Abstract;
using MyWebsite.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.Services
{
    public class ViewsChangesCheckBackgroundService : BackgroundService
    {

        private readonly IMaintenanceCheckService _maintenanceCheckService;
        private readonly IMailService _mailService;
        private readonly EmailSendDto _emailSendDto;
     
        public ViewsChangesCheckBackgroundService(IMaintenanceCheckService maintenanceCheckService, IMailService mailService, IOptions<EmailSendDto> emailSendDto)
        {
            _maintenanceCheckService = maintenanceCheckService;
            _mailService = mailService;
            _emailSendDto = emailSendDto.Value;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            Debug.WriteLine("BackgroundService is started.");

            var currentDirectory = Environment.CurrentDirectory;
            var path = String.Concat(currentDirectory + @"\Views");

            await Task.Delay(1000, stoppingToken);
            FileSystemWatcher watcher = new FileSystemWatcher(path);

            watcher.NotifyFilter = NotifyFilters.Attributes
                                 | NotifyFilters.CreationTime
                                 | NotifyFilters.FileName
                                 | NotifyFilters.Size;

            watcher.Filter = "*.*";
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnCreated);
            watcher.Deleted += new FileSystemEventHandler(OnDeleted);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);
            watcher.Error += new ErrorEventHandler(OnError);


            watcher.IncludeSubdirectories = true;
            watcher.EnableRaisingEvents = true;

        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            if (e.ChangeType != WatcherChangeTypes.Changed)
            {
                return;
            }

            ChangeToMaintenance();            
        }

        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            string value = $"Created: {e.FullPath}";
            ChangeToMaintenance();            
        }

        private void OnDeleted(object sender, FileSystemEventArgs e)
        {
            ChangeToMaintenance();            
        }


        private void OnRenamed(object sender, RenamedEventArgs e)
        {
            Debug.WriteLine($"Renamed:");
            Debug.WriteLine($"    Old: {e.OldFullPath}");
            Debug.WriteLine($"    New: {e.FullPath}");
            ChangeToMaintenance();
        }

        private void OnError(object sender, ErrorEventArgs e)
        {
            ChangeToMaintenance();
            PrintException(e.GetException());
        }


        private void PrintException(Exception? ex)
        {
            if (ex != null)
            {               
                PrintException(ex.InnerException);
                ChangeToMaintenance();
            }
        }

        private void ChangeToMaintenance()
        {
            var check = _maintenanceCheckService.Get(x => x.Id == 1);
            if (!check.IsUnderMaintenance)
            {                
                check.IsUnderMaintenance = true;
                check.EndTime = DateTime.Now.AddHours(4);
                _maintenanceCheckService.Update(check);
                _mailService.Send(_emailSendDto);
            }
        }
    }
}
