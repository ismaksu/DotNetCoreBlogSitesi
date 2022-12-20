using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        //Property'ler

        [Key]
        public int BlogID { get; set; }

        public string BlogTitle { get; set; }

        public string BlogContent { get; set; }

        public string BlogThumbnail { get; set; }

        public string BlogImage { get; set; }

        public DateTime BlogCreationDate { get; set; }

        public bool BlogStat { get; set; }

        //-------------------[İlişkiler]-------------------

        //Category
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        //Comment
        public List<Comment> Comments { get; set; }

        //Author
        public int AuthorID { get; set; }
        public virtual Author Author { get; set; }
    }
}
