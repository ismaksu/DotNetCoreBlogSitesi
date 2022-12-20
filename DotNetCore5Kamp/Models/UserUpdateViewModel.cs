using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore5Kamp.Models
{
    public class UserUpdateViewModel
    {
        public string username { get; set; }
        public string name { get; set; }
        public string mail { get; set; }
        public string imageurl { get; set; }
        public string password { get; set; }
    }
}
