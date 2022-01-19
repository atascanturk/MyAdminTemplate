using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using MyWebsite.Core.Utilities.Results.ComplexTypes;
using MyWebsite.Entities.Dtos;
using MyWebsite.Mvc.Helpers.Abstract;
using MyWebsite.Shared.Utilities.Extensions;
using MyWebsite.Shared.Utilities.Results.Abstract;
using MyWebsite.Shared.Utilities.Results.Concrete;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.Helpers.Concrete
{
    public class MusicHelper : IMusicHelper
    {

        private readonly IWebHostEnvironment _env;
        private readonly string _wwwroot;
        private const string imgFolder = "music";
        private const string uploadedMusicsFolder = "uploadedMusics";
         
        public MusicHelper(IWebHostEnvironment env)
        {
            _env = env;           
            _wwwroot = _env.WebRootPath;
        }

        public IDataResult<MusicDeletedDto> Delete(string pictureName)
        {
            var fileToDelete = Path.Combine($"{_wwwroot}/{imgFolder}/", pictureName);
            if (System.IO.File.Exists(fileToDelete))
            {
                var fileInfo = new FileInfo(fileToDelete);
                var musicDeletedDto = new MusicDeletedDto
                {
                    FullName = pictureName,
                    Extension = fileInfo.Extension,
                    Path = fileInfo.FullName,
                    Size = fileInfo.Length
                };
                System.IO.File.Delete(fileToDelete);
                return new DataResult<MusicDeletedDto>(ResultStatus.Success, musicDeletedDto);
            }
            else
            {
                return new DataResult<MusicDeletedDto>(ResultStatus.Error, $"Böyle bir resim bulunamadı.", null);
            }
        }

        public async Task<IDataResult<MusicUploadedDto>> Upload(string name, IFormFile musicFile, string folderName = null)
        {
            
            folderName = uploadedMusicsFolder;

           
            if (!Directory.Exists($"{_wwwroot}/{imgFolder}/{folderName}"))
            {
                Directory.CreateDirectory($"{_wwwroot}/{imgFolder}/{folderName}");
            }

            
            string oldFileName = Path.GetFileNameWithoutExtension(musicFile.FileName);

            
            string fileExtension = Path.GetExtension(musicFile.FileName);

            if (!fileExtension.Equals("mp3"))
            {
                return new DataResult<MusicUploadedDto>(ResultStatus.Error,new MusicUploadedDto { });
            }

            Regex regex = new("[*'\",._&#^@]");
            name = regex.Replace(name, string.Empty);


            DateTime dateTime = DateTime.Now;
           
            string newFileName = $"{name}_{dateTime.FullDateTimeStringWithUnderscore()}{fileExtension}";

            /* Kendi parametrelerimiz ile sistemimize uygun yeni bir dosya yolu (path) oluşturulur. */
            var path = Path.Combine($"{_wwwroot}/{imgFolder}/{folderName}", newFileName);

            /* Sistemimiz için oluşturulan yeni dosya yoluna muzik kopyalanır. */
            await using (var stream = new FileStream(path, FileMode.Create))
            {
                await musicFile.CopyToAsync(stream);
            }

          
            string nameMessage = "";

            return new DataResult<MusicUploadedDto>(ResultStatus.Success, nameMessage, new MusicUploadedDto
            {
                FullName = $"{folderName}/{newFileName}",
                OldName = oldFileName,
                Extension = fileExtension,
                FolderName = folderName,
                Path = path,
                Size = musicFile.Length
            });
        }
    }
}
