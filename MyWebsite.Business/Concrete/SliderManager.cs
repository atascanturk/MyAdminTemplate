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
    public class SliderManager : ISliderService
    {

        ISliderDal _sliderDal;

        public SliderManager(ISliderDal sliderDal)
        {
            _sliderDal = sliderDal;
        }

        public void Add(Slider slider)
        {

            _sliderDal.Add(slider);
        }

        public void Delete(Slider slider)
        {
            _sliderDal.Delete(slider);
        }

        public Slider Get(Expression<Func<Slider, bool>> filter)
        {
           return _sliderDal.Get(filter);
        }

        public List<Slider> GetAll(Expression<Func<Slider, bool>> filter = null)
        {
            return _sliderDal.GetAll(filter);
        }

        public List<Slider> GetAllByNonDeleted(Expression<Func<Slider, bool>> filter = null)
        {
            return _sliderDal.GetAll(x => !x.IsDeleted);
        }

        public void Update(Slider slider)
        {
            _sliderDal.Update(slider);
        }
    }
}
