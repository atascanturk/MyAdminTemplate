using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyWebsite.Business.Abstract;
using MyWebsite.Core.Utilities.Results.ComplexTypes;
using MyWebsite.Entities.ComplexTypes;
using MyWebsite.Entities.Concrete;
using MyWebsite.Entities.Dtos;
using MyWebsite.Mvc.Helpers.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.Areas.WNqGRjUh3JPe.Controllers
{
    [Area("WNqGRjUh3JPe")]
    [Authorize(Roles= "Admin,SuperAdmin,Developer")]
    public class AlertController : Controller
    {
        IAlertService _alertService;
        IImageHelper _imageHelper;
        IMapper _mapper;

        public AlertController(IAlertService alertService, IMapper mapper, IImageHelper imageHelper)
        {
            _alertService = alertService;
            _mapper = mapper;
            _imageHelper = imageHelper;
        }

        public IActionResult Index()
        {
            var alerts = _alertService.GetAllByNonDeleted();
            return View(alerts);
        }

        [HttpGet]
        public IActionResult AddAlert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAlert(AlertAddDto alertAddDto)
        {
            if (ModelState.IsValid)
            {
                var alert = _mapper.Map<Alert>(alertAddDto);
                if (!_alertService.GetAllByNonDeleted().Any())
                {
                    var imageResult = _imageHelper.Upload("Alert", alertAddDto.File, PictureType.Alert, "alert");
                    if (imageResult.Result.ResultStatus == ResultStatus.Success)
                    {
                        alert.FilePath = imageResult.Result.Data.FullName;
                        var result = _alertService.Add(alert);
                        if (result.ResultStatus == ResultStatus.Success)
                        {
                            return RedirectToAction("Index", new { Area = "WNqGRjUh3JPe" });

                        }
                        else
                        {
                            ModelState.AddModelError("OnlyOneCheck", result.Message);
                            return View(alertAddDto);
                        }
                    }

                    else
                    {
                        ModelState.AddModelError("AlertFileFormat", "Dosya formatı yalnızca .jpg , .png veya .mp4 olabilir.");
                        return View(alertAddDto);
                    }
                }

                else
                {
                    ModelState.AddModelError("OnlyOneCheck", "Yalnızca 1 adet önemli duyuru kaydedilebilir. Yeni bir duyuru kaydetmek için lütfen var olanı siliniz.");
                    return View(alertAddDto);
                }
                           
                              
            }

            else
            {
                return View(alertAddDto);
            }
           
        }

        [HttpGet]
        public IActionResult UpdateAlert(int id)
        {
          var alert = _alertService.Get(x => x.Id == id);
            var alertupdateDto = _mapper.Map<AlertUpdateDto>(alert);
            return View(alertupdateDto);
        }

        [HttpPost]
        public IActionResult UpdateAlert(AlertUpdateDto alertUpdateDto)
        {
            if (ModelState.IsValid)
            {
                bool isNewPictureUploaded = false;
                var oldAlert = _alertService.Get(x => x.Id == alertUpdateDto.Id);

                var oldAlertPicture = oldAlert.FilePath;
                if (alertUpdateDto.File != null)
                {
                    var uploadedImageResult = _imageHelper.Upload("Alert",
                      alertUpdateDto.File, PictureType.Alert).Result;
                    alertUpdateDto.FilePath = uploadedImageResult.Data.FullName;

                    isNewPictureUploaded = true;
                }

                if (isNewPictureUploaded)
                {
                    _imageHelper.Delete(oldAlertPicture);
                }               

                var alert = _mapper.Map<Alert>(alertUpdateDto);
                _alertService.Update(alert);
                return RedirectToAction("Index", new { Area = "WNqGRjUh3JPe" });
            }
            else
            {
                return View(alertUpdateDto);
            }
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var alert = _alertService.Get(x => x.Id == id);
            alert.IsDeleted = true;
            _imageHelper.Delete(alert.FilePath);
            var jsonAlert = JsonSerializer.Serialize(alert);
            _alertService.Update(alert);

            return Json(jsonAlert);

        }
    }
}
