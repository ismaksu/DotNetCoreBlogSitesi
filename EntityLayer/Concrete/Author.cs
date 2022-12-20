using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Author
    {
        //Property'ler

        [Key]
        public int AuthorID { get; set; }

        public string AuthorName { get; set; }

        public string AuthorDesc { get; set; }

        public string AuthorImage { get; set; }

        public string AuthorMail { get; set; }

        public string AuthorPassword { get; set; }

        public bool AuthorStat { get; set; }

        //-------------------[İlişkiler]-------------------

        public List<Blog> Blogs { get; set; }

        public virtual ICollection<Message2> Sender { get; set; }
        public virtual ICollection<Message2> Receiver { get; set; }

    }
}
