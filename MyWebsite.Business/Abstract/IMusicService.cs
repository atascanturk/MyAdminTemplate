using MyWebsite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Business.Abstract
{
   public interface IMusicService
    {
        List<Music> GetAll(Expression<Func<Music, bool>> filter = null);
        List<Music> GetAllByNonDeleted(Expression<Func<Music, bool>> filter = null);
        Music Get(Expression<Func<Music, bool>> filter);
        void Add(Music music);
        void Update(Music music);
        void Delete(Music music);
    }
}
