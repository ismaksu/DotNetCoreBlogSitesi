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
    public class AdminManager : IAdminService
    {
        IAdminDAL _adminDal;

        public AdminManager(IAdminDAL adminDal)
        {
            _adminDal = adminDal;
        }

        public void AddEntity(Admin t)
        {
            _adminDal.Insert(t);
        }

        public void DeleteEntity(Admin t)
        {
            _adminDal.Delete(t);
        }

        public Admin FindByID(int id)
        {
            return _adminDal.FindByID(id);
        }

        public List<Admin> ListEntity()
        {
            return _adminDal.ListAll();
        }

        public void UpdateEntity(Admin t)
        {
            _adminDal.Update(t);
        }
    }
}
