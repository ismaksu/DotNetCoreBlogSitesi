﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDAL<T> where T : class
    {
        void Insert(T t);

        void Delete(T t);

        void Update(T t);

        List<T> ListAll();

        List<T> ListAll(Expression<Func<T, bool>> filter);

        T FindByID(int id);
    }
}
