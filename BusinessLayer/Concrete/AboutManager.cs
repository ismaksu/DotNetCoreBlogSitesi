using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDAL _aboutDal;

        public AboutManager(IAboutDAL aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void AddEntity(About t)
        {
            _aboutDal.Insert(t);
        }

        public void DeleteEntity(About t)
        {
            _aboutDal.Delete(t);
        }

        public About FindByID(int id)
        {
            return _aboutDal.FindByID(id);
        }

        public List<About> ListEntity()
        {
            return _aboutDal.ListAll();
        }

        public void UpdateEntity(About t)
        {
            _aboutDal.Update(t);
        }
    }
}
