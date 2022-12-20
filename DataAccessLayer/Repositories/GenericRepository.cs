using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDAL<T> where T : class
    {

        Context c = new Context();

        public void Delete(T t)
        {
            c.Remove(t);
            c.SaveChanges();
        }

        public T FindByID(int id)
        {
            return c.Set<T>().Find(id);
        }

        public List<T> ListAll(Expression<Func<T, bool>> filter)
        {
            return c.Set<T>().Where(filter).ToList();
        }

        public void Insert(T t)
        {
            c.Add(t);
            c.SaveChanges();
        }

        public List<T> ListAll()
        {
            return c.Set<T>().ToList();
        }

        public void Update(T t)
        {
            c.Update(t);
            c.SaveChanges();
        }
    }
}
