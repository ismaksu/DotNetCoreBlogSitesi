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
    public class UserManager : IUserService
    {
        IUserDAL _userDal;

        public UserManager(IUserDAL userDal)
        {
            _userDal = userDal;
        }

        public void AddEntity(AppUser t)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(AppUser t)
        {
            throw new NotImplementedException();
        }

        public AppUser FindByID(int id)
        {
            return _userDal.FindByID(id);
        }

        public List<AppUser> ListEntity()
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(AppUser t)
        {
            _userDal.Update(t);
        }
    }
}
