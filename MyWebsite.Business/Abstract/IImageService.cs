using MyWebsite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Business.Abstract
{
    public interface IImageService
    {
        List<Image> GetAll(Expression<Func<Image, bool>> filter = null);
        List<Image> GetAllByNonDeleted(Expression<Func<Image, bool>> filter = null);
        Image Get(Expression<Func<Image, bool>> filter);
        void Add(Image image);
        void Update(Image image);
        void Delete(Image image);
    }
}
