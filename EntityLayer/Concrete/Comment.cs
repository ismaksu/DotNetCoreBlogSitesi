using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        //Property'ler

        [Key]
        public int CommentID { get; set; }

        public string CommentTitle { get; set; }

        public string CommentValue { get; set; }

        public string CommentUserName { get; set; }

        public DateTime CommentDate { get; set; }

        public int BlogScore { get; set; }

        public bool CommentStat { get; set; }

        //-------------------[İlişkiler]-------------------

        //Blog
        public int BlogID { get; set; }
        public virtual Blog Blog { get; set; }
    }
}
