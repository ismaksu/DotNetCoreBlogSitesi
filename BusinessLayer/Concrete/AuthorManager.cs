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
    public class AuthorManager : IAuthorService
    {
        IAuthorDAL _authorDal;

        public AuthorManager(IAuthorDAL authorDal)
        {
            _authorDal = authorDal;
        }

        public void AddEntity(Author t)
        {
            _authorDal.Insert(t);
        }

        public void DeleteEntity(Author t)
        {
            _authorDal.Delete(t);
        }

        public Author FindByID(int id)
        {
            return _authorDal.FindByID(id);
        }

        public List<Author> ListEntity()
        {
            return _authorDal.ListAll();
        }

        public List<Author> ListWriterByID(int id)
        {
            return _authorDal.ListAll(x => x.AuthorID == id);
        }

        public void UpdateEntity(Author t)
        {
            _authorDal.Update(t);
        }
    }
}
