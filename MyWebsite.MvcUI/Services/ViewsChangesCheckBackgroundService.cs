using Microsoft.Extensions.Hosting;
using MyWebsite.Business.Abstract;
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

        IMaintenanceCheckService _maintenanceCheckService;

        public ViewsChangesCheckBackgroundService(IMaintenanceCheckService maintenanceCheckService)
        {
            _maintenanceCheckService = maintenanceCheckService;
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

            Debug.WriteLine($"Changed: {e.FullPath}");
        }

        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            string value = $"Created: {e.FullPath}";
            ChangeToMaintenance();
            Debug.WriteLine(value);
        }

        private void OnDeleted(object sender, FileSystemEventArgs e)
        {
            ChangeToMaintenance();
            Debug.WriteLine($"Deleted: {e.FullPath}");
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
                Debug.WriteLine($"Message: {ex.Message}");
                Debug.WriteLine("Stacktrace:");
                Debug.WriteLine(ex.StackTrace);
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
                _maintenanceCheckService.Update(check);               
            }
        }
    }
}
