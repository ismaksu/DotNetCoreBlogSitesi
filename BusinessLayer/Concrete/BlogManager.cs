using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDAL _blogDal;

        public BlogManager(IBlogDAL blogDal)
        {
            _blogDal = blogDal;
        }

        public void AddEntity(Blog t)
        {
            _blogDal.Insert(t);
        }

        public void DeleteEntity(Blog t)
        {
            _blogDal.Delete(t);
        }

        public Blog FindByID(int id)
        {
            return _blogDal.FindByID(id);
        }

        public List<Blog> ListBlogByAuthor(int id)
        {
            return _blogDal.ListAll(x => x.AuthorID == id);
        }

        public List<Blog> ListBlogByID(int id)
        {
            return _blogDal.ListAll(x => x.BlogID == id);
        }

        public List<Blog> ListBlogWithCategory()
        {
            return _blogDal.ListWithCategory();
        }

        public List<Blog> ListBlogWithCategory(int id)
        {
            return _blogDal.ListWithCategoryByAuthor(id);
        }

        public List<Blog> ListEntity()
        {
            return _blogDal.ListAll();
        }

        public List<Blog> ListLastXBlog(int x)
        {
            return _blogDal.ListAll().Take(x).ToList();
        }

        public void UpdateEntity(Blog t)
        {
            _blogDal.Update(t);
        }
    }
}
