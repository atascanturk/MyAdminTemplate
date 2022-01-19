using MyWebsite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Business.Abstract
{
    public interface IAnnouncementService
    {
        List<Announcement> GetAll(Expression<Func<Announcement, bool>> filter = null);
        List<Announcement> GetAllByNonDeleted(Expression<Func<Announcement, bool>> filter = null);
        Announcement Get(Expression<Func<Announcement, bool>> filter);
        void Add(Announcement announcement);
        void Update(Announcement announcement);
        void Delete(Announcement announcement);
    }
}
