using MyWebsite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Business.Abstract
{
    public interface ISliderService
    {
        List<Slider> GetAllByNonDeleted(Expression<Func<Slider, bool>> filter = null);
        Slider Get(Expression<Func<Slider, bool>> filter);
        void Add(Slider slider);
        void Update(Slider slider);
        void Delete(Slider slider);
    }
}
