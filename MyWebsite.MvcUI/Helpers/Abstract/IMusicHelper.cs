using Microsoft.AspNetCore.Http;
using MyWebsite.Core.Utilities.Results.Abstract;
using MyWebsite.Entities.ComplexTypes;
using MyWebsite.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.Mvc.Helpers.Abstract
{
   public interface IMusicHelper        
    {
        Task<IDataResult<MusicUploadedDto>> Upload(string name, IFormFile pictureFile, string folderName = null);
        IDataResult<MusicDeletedDto> Delete(string pictureName);
    }
}

