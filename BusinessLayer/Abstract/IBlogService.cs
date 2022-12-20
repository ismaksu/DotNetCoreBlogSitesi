using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService:IGenericService<Blog>
    {

        List<Blog> ListBlogByID(int id);

        List<Blog> ListBlogWithCategory();

        List<Blog> ListBlogByAuthor(int id);

        List<Blog> ListLastXBlog(int x);
    }
}
