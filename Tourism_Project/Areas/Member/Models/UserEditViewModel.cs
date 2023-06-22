﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tourism_Project.Areas.Member.Models
{
    public class UserEditViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string PhoneNumber { get; set; }
        public string Mail { get; set; }
        public string imageurl { get; set; }
        public IFormFile Image { get; set; }
    }
}
