using MyWebsite.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Business.Abstract
{
    public interface IUserCheckService
    {
        bool CheckIfUserRealPerson(Person person);
    }
}
