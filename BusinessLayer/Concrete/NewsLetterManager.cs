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
    public class NewsLetterManager : INewsLetterService
    {
        INewsLetterDAL _newsDal;

        public NewsLetterManager(INewsLetterDAL newsDal)
        {
            _newsDal = newsDal;
        }

        public void AddNews(NewsLetter newsLetter)
        {
            _newsDal.Insert(newsLetter);
        }

        public void DeleteNews(NewsLetter newsLetter)
        {
            _newsDal.Delete(newsLetter);
        }

        public NewsLetter FindByID(int id)
        {
            return _newsDal.FindByID(id);
        }

        public List<NewsLetter> ListNews()
        {
            return _newsDal.ListAll();
        }

        public void UpdateNews(NewsLetter newsLetter)
        {
            _newsDal.Update(newsLetter);
        }
    }
}
