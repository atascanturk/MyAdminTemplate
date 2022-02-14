using MyWebsite.Core.Utilities.Results.Abstract;
using MyWebsite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Business.Abstract
{
    public interface IAlertService
    {
        List<Alert> GetAll(Expression<Func<Alert, bool>> filter = null);
        List<Alert> GetAllByNonDeleted(Expression<Func<Alert, bool>> filter = null);
        Alert Get(Expression<Func<Alert, bool>> filter);
        IResult Add(Alert alert);
        void Update(Alert alert);
        void Delete(Alert alert);
    }
}
