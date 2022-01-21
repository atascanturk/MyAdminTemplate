using MyWebsite.Business.Abstract;
using MyWebsite.Core.Aspects.Autofac.Caching;
using MyWebsite.Core.Utilities.Results.Abstract;
using MyWebsite.Core.Utilities.Results.ComplexTypes;
using MyWebsite.Core.Utilities.Results.Concrete;
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
        IUserCheckService _userCheckService;

        public MemberManager(IMemberDal memberDal, IUserCheckService userCheckService)
        {
            _memberDal = memberDal;
            _userCheckService = userCheckService;
        }

        [CacheRemoveAspect("IMemberService.Get")]
        public IResult Add(Member member)
        {
           var checkResult = _userCheckService.CheckIfUserRealPerson(member);
            if (checkResult)
            {
                if(_memberDal.GetAll(x=>x.IdentityNumber == member.IdentityNumber).Any())
                {
                    return new Result(ResultStatus.Error, "Bu üye sistemde mevcut.");
                }

                _memberDal.Add(member);

                return new Result(ResultStatus.Success);
            }

            return new Result (ResultStatus.Error, "Kişi bilgileri hatalıdır. Lütfen kontrol edip tekrar deneyiniz." );
        }

        [CacheRemoveAspect("IMemberService.Get")]
        public void Delete(Member member)
        {
            _memberDal.Delete(member);
        }

        [CacheAspect]
        public Member Get(Expression<Func<Member, bool>> filter)
        {
            return _memberDal.Get(filter);
        }

        [CacheAspect]
        public List<Member> GetAll(Expression<Func<Member, bool>> filter = null)
        {
            return _memberDal.GetAll(filter);
        }

        [CacheRemoveAspect("IMemberService.Get")]
        public void Update(Member member)
        {
            _memberDal.Update(member);
        }
    }
}
