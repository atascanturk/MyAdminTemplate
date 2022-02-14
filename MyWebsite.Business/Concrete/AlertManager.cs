using MyWebsite.Business.Abstract;
using MyWebsite.Core.Aspects.Autofac.Caching;
using MyWebsite.Core.Utilities.Results.Abstract;
using MyWebsite.Core.Utilities.Results.ComplexTypes;
using MyWebsite.Core.Utilities.Results.Concrete;
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
    public class AlertManager : IAlertService
    {
        IAlertDal _alertDal;

        public AlertManager(IAlertDal alertDal)
        {
            _alertDal = alertDal;
        }

        [CacheRemoveAspect("IAlertService.Get")]
        public IResult Add(Alert alert)
        {
            
            if (!_alertDal.GetAll().Where(x => !x.IsDeleted).Any())
            {
                _alertDal.Add(alert);
                return new Result(ResultStatus.Success);
            }
           return new Result(ResultStatus.Error,"Kayıtlı bir adet duyuru varken diğerini kaydedemezsiniz.");
        }

        [CacheRemoveAspect("IAlertService.Get")]
        public void Delete(Alert alert)
        {
            _alertDal.Delete(alert);
        }

        [CacheAspect]
        public Alert Get(Expression<Func<Alert, bool>> filter)
        {
           return _alertDal.Get(filter);
        }

        [CacheAspect]
        public List<Alert> GetAll(Expression<Func<Alert, bool>> filter = null)
        {
            return _alertDal.GetAll();
        }

        [CacheAspect]
        public List<Alert> GetAllByNonDeleted(Expression<Func<Alert, bool>> filter = null)
        {
            return _alertDal.GetAll(x=>!x.IsDeleted);
        }

        [CacheRemoveAspect("IAlertService.Get")]
        public void Update(Alert alert)
        {
            _alertDal.Update(alert);
        }
    }
}
