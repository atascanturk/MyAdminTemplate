using MyWebsite.Core.DataAccess.EntityFramework;
using MyWebsite.DataAccess.Abstract;
using MyWebsite.DataAccess.Concrete.EntityFramework.Contexts;
using MyWebsite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfVideoDal : EfEntityRepositoryBase<Video, MyDbContext>, IVideoDal
    {
    }
}
