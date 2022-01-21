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
   public interface IImageHelper
    {
        Task<IDataResult<ImageUploadedDto>> Upload(string name, IFormFile pictureFile, PictureType pictureType, string folderName = null);
        IDataResult<ImageDeletedDto> Delete(string pictureName);
    }
}
