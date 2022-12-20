using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore5Kamp.Models
{
    public class AddProfileImage
    {
        public int AuthorID { get; set; }

        public string AuthorName { get; set; }

        public string AuthorDesc { get; set; }

        public IFormFile AuthorImage { get; set; }

        public string AuthorMail { get; set; }

        public string AuthorPassword { get; set; }

        public bool AuthorStat { get; set; }
    }
}
