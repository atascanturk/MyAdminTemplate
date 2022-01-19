using MyWebsite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Business.Abstract
{
    public interface IMemberService
    {
        List<Member> GetAll(Expression<Func<Member, bool>> filter = null);
        Member Get(Expression<Func<Member, bool>> filter);
        void Add(Member member);
        void Update(Member member);
        void Delete(Member member);
    }
}
