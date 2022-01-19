using MyWebsite.Core.DataAccess;
using MyWebsite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.DataAccess.Abstract
{
    public interface ISocialMediaDal : IEntityRepository<SocialMedia>
    {
    }
}
