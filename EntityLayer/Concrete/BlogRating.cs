﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class BlogRating
    {
        [Key]
        public int RatingID { get; set; }

        public int BlogID { get; set; }

        public int RatingScore { get; set; }

        public int TotalComments { get; set; }
    }
}
