using MyWebsite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Business.Abstract
{
   public interface IProjectService
    {
        List<Project> GetAll(Expression<Func<Project, bool>> filter = null);       
        List<Project> GetAllByNonDeleted(Expression<Func<Project, bool>> filter = null);
        Project Get(Expression<Func<Project, bool>> filter);
        Project GetByIdNonDeleted(int id, Expression<Func<Project, bool>> filter);
        void Add(Project project);
        void Update(Project project);
        void Delete(Project project);
    }
}
