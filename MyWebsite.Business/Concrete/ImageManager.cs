using MyWebsite.Business.Abstract;
using MyWebsite.DataAccess.Abstract;
using MyWebsite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Business.Concrete
{
    public class ImageManager : IImageService
    {
        IImageDal _imageDal;

        public ImageManager(IImageDal imageDal)
        {
            _imageDal = imageDal;
        }

        public void Add(Image image)
        {
            _imageDal.Add(image);
        }

        public void Delete(Image image)
        {
            _imageDal.Delete(image);
        }

        public Image Get(Expression<Func<Image, bool>> filter)
        {
           return _imageDal.Get(filter);
        }

        public List<Image> GetAll(Expression<Func<Image, bool>> filter = null)
        {
            return _imageDal.GetAll(filter);
        }

        public List<Image> GetAllByNonDeleted(Expression<Func<Image, bool>> filter = null)
        {
            return _imageDal.GetAll(x => !x.IsDeleted);
        }

        public void Update(Image image)
        {
            _imageDal.Update(image);
        }
    }
}
