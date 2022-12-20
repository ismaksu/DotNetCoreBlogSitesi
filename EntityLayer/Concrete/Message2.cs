using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Message2
    {
        [Key]
        public int MessageID { get; set; }

        public int? SenderID { get; set; }

        public int? ReceiverID { get; set; }

        public string MessageTitle { get; set; }

        public string MessageContent { get; set; }

        public DateTime MessageDate { get; set; }

        public bool MessageStat { get; set; }

        //-------------------[İlişkiler]-------------------
        
        public Author SenderUser { get; set; }

        public Author ReceiverUser { get; set; }
    }
}
