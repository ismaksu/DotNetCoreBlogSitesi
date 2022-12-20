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
    public class CommentManager : ICommentService
    {
        ICommentDAL _commentDal;

        public CommentManager(ICommentDAL commentDal)
        {
            _commentDal = commentDal;
        }

        public void AddComment(Comment comment)
        {
            _commentDal.Insert(comment);
        }

        public void DeleteComment(Comment comment)
        {
            _commentDal.Delete(comment);
        }

        public Comment FindByID(int id)
        {
            return _commentDal.FindByID(id);
        }

        public List<Comment> ListComment(int id)
        {
            return _commentDal.ListAll(x => x.BlogID == id);
        }

        public List<Comment> ListComment()
        {
            return _commentDal.ListAll();
        }

        public List<Comment> ListCommentWithBlog()
        {
            return _commentDal.ListCommentWithBlog();
        }

        public void UpdateComment(Comment comment)
        {
            _commentDal.Update(comment);
        }
    }
}
