using MyWebsite.Business.Abstract;
using MyWebsite.Core.Aspects.Autofac.Caching;
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
    public class SliderManager : ISliderService
    {

        ISliderDal _sliderDal;

        public SliderManager(ISliderDal sliderDal)
        {
            _sliderDal = sliderDal;
        }

        [CacheRemoveAspect("ISliderService.Get")]
        public void Add(Slider slider)
        {

            _sliderDal.Add(slider);
        }

        [CacheRemoveAspect("ISliderService.Get")]
        public void Delete(Slider slider)
        {
            _sliderDal.Delete(slider);
        }

       
        public Slider Get(Expression<Func<Slider, bool>> filter)
        {
           return _sliderDal.Get(filter);
        }

        [CacheAspect]
        public List<Slider> GetAll(Expression<Func<Slider, bool>> filter = null)
        {
            return _sliderDal.GetAll(filter);
        }

        [CacheAspect]
        public List<Slider> GetAllByNonDeleted(Expression<Func<Slider, bool>> filter = null)
        {
            return _sliderDal.GetAll(x => !x.IsDeleted);
        }

        [CacheRemoveAspect("ISliderService.Get")]
        public void Update(Slider slider)
        {
            _sliderDal.Update(slider);
        }
    }
}
