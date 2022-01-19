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
    public class MusicManager : IMusicService
    {
        IMusicDal _musicDal;

        public MusicManager(IMusicDal musicDal)
        {
            _musicDal = musicDal;
        }

        public void Add(Music music)
        {
            _musicDal.Add(music);
        }

        public void Delete(Music music)
        {
            _musicDal.Delete(music);
        }

        public Music Get(Expression<Func<Music, bool>> filter)
        {
           return _musicDal.Get(filter);
        }

        public List<Music> GetAll(Expression<Func<Music, bool>> filter = null)
        {
            return _musicDal.GetAll(filter);
        }

        public List<Music> GetAllByNonDeleted(Expression<Func<Music, bool>> filter = null)
        {
            return _musicDal.GetAll(x => !x.IsDeleted);
        }

        public void Update(Music music)
        {
            _musicDal.Update(music);
        }
    }
}
