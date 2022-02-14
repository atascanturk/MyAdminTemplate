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
    public class ProjectManager : IProjectService
    {
        IProjecDal _projecDal;

        public ProjectManager(IProjecDal projecDal)
        {
            _projecDal = projecDal;
        }

        public void Add(Project project)
        {
            _projecDal.Add(project);
        }

        public void Delete(Project project)
        {
            _projecDal.Delete(project);
        }

        public Project Get(Expression<Func<Project, bool>> filter)
        {
            return _projecDal.Get(filter);
        }

        public List<Project> GetAll(Expression<Func<Project, bool>> filter = null)
        {
            return _projecDal.GetAll(filter);
        }

        public List<Project> GetAllByNonDeleted(Expression<Func<Project, bool>> filter = null)
        {
            return _projecDal.GetAll(x => !x.IsDeleted);
        }

        public Project GetByIdNonDeleted(int id, Expression<Func<Project, bool>> filter)
        {
            return _projecDal.Get(x => x.Id == id && !x.IsDeleted);
        }

        public void Update(Project project)
        {
            _projecDal.Update(project);
        }
    }
}
