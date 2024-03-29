﻿using MyWebsite.Business.Abstract;
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
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void Add(Contact contact)
        {
            _contactDal.Add(contact);
        }

        public void Delete(Contact contact)
        {
            _contactDal.Delete(contact);
        }

        public Contact Get(Expression<Func<Contact, bool>> filter)
        {
            return _contactDal.Get(filter);
        }

        public List<Contact> GetAll(Expression<Func<Contact, bool>> filter = null)
        {
            return _contactDal.GetAll(filter);
        }

        public List<Contact> GetAllByNonDeleted(Expression<Func<Contact, bool>> filter = null)
        {
            return _contactDal.GetAll(x => !x.IsDeleted);
        }

        public void Update(Contact contact)
        {
            _contactDal.Update(contact);
        }
    }
}
