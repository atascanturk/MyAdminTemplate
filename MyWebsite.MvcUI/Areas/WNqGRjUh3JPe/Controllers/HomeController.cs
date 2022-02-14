using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyWebsite.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.MvcUI.Areas.Admin.Controllers
{
    [Area("WNqGRjUh3JPe")]
    [Authorize(Roles = "Admin,SuperAdmin,Developer")]
    public class HomeController : Controller
    {
        IContactService _contactService;
        INewsService _newsService;
        IAnnouncementService _announcementService;
        IVisitorCountService _visitorCountService;
        IMemberService _memberService;

        public HomeController(IContactService contactService, INewsService newsService, IAnnouncementService announcementService, IVisitorCountService visitorCountService, IMemberService memberService)
        {
            _contactService = contactService;
            _newsService = newsService;
            _announcementService = announcementService;
            _visitorCountService = visitorCountService;
            _memberService = memberService;
        }

        public IActionResult Index()
        {
            int memberCount;
            try
            {
               memberCount = _memberService.GetAll().GroupBy(info => info.CreatedDate.Month)
                                     .Select(group => new
                                     {
                                         Metric = group.Key,
                                         Count = group.Count()
                                     })
                                     .OrderByDescending(x => x.Count).FirstOrDefault().Count;
            }
            catch (Exception)
            {
                memberCount = 100;
               
            }
        



            ViewBag.UnReadContact = _contactService.GetAll(x => !x.IsRead).Count;
            ViewBag.AnnouncementCount = _announcementService.GetAll(x => !x.IsDeleted).Count;
            ViewBag.NewsCount = _newsService.GetAll(x => !x.IsDeleted).Count;
            ViewBag.MemberCount = _memberService.GetAll(x => !x.IsDeleted).Count;
            ViewBag.VisitorGraphMax = _visitorCountService.GetAll().Select(x=>x.Count).Max()*2;

           ViewBag.MemberGraphMax = memberCount*2;





            return View();
        }

        public IActionResult VisitorChart()
        {
            var counts = _visitorCountService.GetAll();

            List<VisitorChart> chartList = new List<VisitorChart>();

            #region AddingChartValues
            chartList.Add(new VisitorChart
            {
                Month = "Ocak",
                Count = counts.Where(x => x.Month == 1 && x.Year == DateTime.Now.Year).FirstOrDefault().Count
            });
            chartList.Add(new VisitorChart
            {
                Month = "Şubat",
                Count = counts.Where(x => x.Month == 2 && x.Year == DateTime.Now.Year).FirstOrDefault().Count
            });
            chartList.Add(new VisitorChart
            {
                Month = "Mart",
                Count = counts.Where(x => x.Month == 3 && x.Year == DateTime.Now.Year).FirstOrDefault().Count
            });
            chartList.Add(new VisitorChart
            {
                Month = "Nisan",
                Count = counts.Where(x => x.Month == 4 && x.Year == DateTime.Now.Year).FirstOrDefault().Count
            });
            chartList.Add(new VisitorChart
            {
                Month = "Mayıs",
                Count = counts.Where(x => x.Month == 5 && x.Year == DateTime.Now.Year).FirstOrDefault().Count
            });
            chartList.Add(new VisitorChart
            {
                Month = "Haziran",
                Count = counts.Where(x => x.Month == 6 && x.Year == DateTime.Now.Year).FirstOrDefault().Count
            });
            chartList.Add(new VisitorChart
            {
                Month = "Temmuz",
                Count = counts.Where(x => x.Month == 7 && x.Year == DateTime.Now.Year).FirstOrDefault().Count
            });
            chartList.Add(new VisitorChart
            {
                Month = "Ağustos",
                Count = counts.Where(x => x.Month == 8 && x.Year == DateTime.Now.Year).FirstOrDefault().Count
            });
            chartList.Add(new VisitorChart
            {
                Month = "Eylül",
                Count = counts.Where(x => x.Month == 9 && x.Year == DateTime.Now.Year).FirstOrDefault().Count
            });
            chartList.Add(new VisitorChart
            {
                Month = "Ekim",
                Count = counts.Where(x => x.Month == 10 && x.Year == DateTime.Now.Year).FirstOrDefault().Count
            });
            chartList.Add(new VisitorChart
            {
                Month = "Kasım",
                Count = counts.Where(x => x.Month == 11 && x.Year == DateTime.Now.Year).FirstOrDefault().Count
            });
            chartList.Add(new VisitorChart
            {
                Month = "Aralık",
                Count = counts.Where(x => x.Month == 12 && x.Year == DateTime.Now.Year).FirstOrDefault().Count
            });
            #endregion

            return Json(new { jsonlist = chartList });
        }


        public IActionResult MemberChart()
        {
            var members = _memberService.GetAll();
            List<MemberChart> chartList = new List<MemberChart>();

            #region AddingChartValues
            chartList.Add(new MemberChart
            {
                Count = members.Where(x => x.CreatedDate.Month == 1 && x.CreatedDate.Year == DateTime.Now.Year).Count(),
                Month = "Ocak"
            });
            chartList.Add(new MemberChart
            {
                Count = members.Where(x => x.CreatedDate.Month == 2 && x.CreatedDate.Year == DateTime.Now.Year).Count(),
                Month = "Şubat"
            });
            chartList.Add(new MemberChart
            {
                Count = members.Where(x => x.CreatedDate.Month == 3 && x.CreatedDate.Year == DateTime.Now.Year).Count(),
                Month = "Mart"
            });
            chartList.Add(new MemberChart
            {
                Count = members.Where(x => x.CreatedDate.Month == 4 && x.CreatedDate.Year == DateTime.Now.Year).Count(),
                Month = "Nisan"
            });
            chartList.Add(new MemberChart
            {
                Count = members.Where(x => x.CreatedDate.Month == 5 && x.CreatedDate.Year == DateTime.Now.Year).Count(),
                Month = "Mayıs"
            });
            chartList.Add(new MemberChart
            {
                Count = members.Where(x => x.CreatedDate.Month == 6 && x.CreatedDate.Year == DateTime.Now.Year).Count(),
                Month = "Haziran"
            });
            chartList.Add(new MemberChart
            {
                Count = members.Where(x => x.CreatedDate.Month == 7 && x.CreatedDate.Year == DateTime.Now.Year).Count(),
                Month = "Temmuz"
            });
            chartList.Add(new MemberChart
            {
                Count = members.Where(x => x.CreatedDate.Month == 8 && x.CreatedDate.Year == DateTime.Now.Year).Count(),
                Month = "Ağustos"
            });
            chartList.Add(new MemberChart
            {
                Count = members.Where(x => x.CreatedDate.Month == 9 && x.CreatedDate.Year == DateTime.Now.Year).Count(),
                Month = "Eylül"
            });

            chartList.Add(new MemberChart
            {
                Count = members.Where(x => x.CreatedDate.Month == 10 && x.CreatedDate.Year == DateTime.Now.Year).Count(),
                Month = "Ekim"
            });
            chartList.Add(new MemberChart
            {
                Count = members.Where(x => x.CreatedDate.Month == 11 && x.CreatedDate.Year == DateTime.Now.Year).Count(),
                Month = "Kasım"
            });
            chartList.Add(new MemberChart
            {
                Count = members.Where(x => x.CreatedDate.Month == 12 && x.CreatedDate.Year == DateTime.Now.Year).Count(),
                Month = "Aralık"
            });
            #endregion

            return Json(new { jsonlist = chartList });
        }

    }

    public class VisitorChart
    {
        public string Month { get; set; }
        public long Count { get; set; }
    }

    public class MemberChart
    {
        public string Month { get; set; }
        public long Count { get; set; }
    }
}
