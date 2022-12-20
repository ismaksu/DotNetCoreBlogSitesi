using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDAL _categoryDal;

        public CategoryManager(ICategoryDAL categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void AddEntity(Category t)
        {
            _categoryDal.Insert(t);
        }

        public void DeleteEntity(Category t)
        {
            _categoryDal.Delete(t);
        }

        public Category FindByID(int id)
        {
            return _categoryDal.FindByID(id);
        }

        public List<Category> ListEntity()
        {
            return _categoryDal.ListAll();
        }

        public void UpdateEntity(Category t)
        {
            _categoryDal.Update(t);
        }
    }
}
