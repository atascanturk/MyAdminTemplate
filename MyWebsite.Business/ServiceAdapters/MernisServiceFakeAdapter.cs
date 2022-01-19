using MyWebsite.Business.Abstract;
using MyWebsite.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Business.ServiceAdapters
{
    public class MernisServiceFakeAdapter : IUserCheckService
    {
        public bool CheckIfUserRealPerson(Person person)
        {
            return true;
        }
    }
}
