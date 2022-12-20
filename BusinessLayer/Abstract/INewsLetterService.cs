using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface INewsLetterService
    {
        void AddNews(NewsLetter newsLetter);

        void DeleteNews(NewsLetter newsLetter);

        void UpdateNews(NewsLetter newsLetter);

        List<NewsLetter> ListNews();

        NewsLetter FindByID(int id);
    }
}
