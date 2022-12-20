﻿using System.ComponentModel.DataAnnotations;

namespace DotNetCore5Kamp.Models
{
    public class RoleViewModel
    {
        [Required(ErrorMessage = "Lütfen rol adı giriniz.")]
        public string name { get; set; }
    }
}
