using MyWebsite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Business.Abstract
{
    public interface IContactService
    {
        List<Contact> GetAll(Expression<Func<Contact, bool>> filter = null);
        List<Contact> GetAllByNonDeleted(Expression<Func<Contact, bool>> filter = null);
        Contact Get(Expression<Func<Contact, bool>> filter);
        void Add(Contact contact);
        void Update(Contact contact);
        void Delete(Contact contact);
    }
}
