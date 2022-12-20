﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFBlogRepository : GenericRepository<Blog>, IBlogDAL
    {
        public List<Blog> ListWithCategory()
        {
            using(var c = new Context())
            {
                return c.Blogs.Include(x => x.Category).ToList();
            } 
        }

        public List<Blog> ListWithCategoryByAuthor(int id)
        {
            using (var c = new Context())
            {
                return c.Blogs.Include(x => x.Category).Where(x => x.AuthorID == id).ToList();
            }
        }
    }
}
