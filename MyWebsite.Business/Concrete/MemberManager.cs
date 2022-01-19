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
    public class MemberManager : IMemberService
    {
        IMemberDal _memberDal;

        public MemberManager(IMemberDal memberDal)
        {
            _memberDal = memberDal;
        }

        public void Add(Member member)
        {
            _memberDal.Add(member);
        }

        public void Delete(Member member)
        {
            _memberDal.Delete(member);
        }

        public Member Get(Expression<Func<Member, bool>> filter)
        {
            return _memberDal.Get(filter);
        }

        public List<Member> GetAll(Expression<Func<Member, bool>> filter = null)
        {
            return _memberDal.GetAll(filter);
        }

        public void Update(Member member)
        {
            _memberDal.Update(member);
        }
    }
}
