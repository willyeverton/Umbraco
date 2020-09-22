﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Umbraco.Models
{
    public class ContactModel
    {
        [Required]
        public string name { get; set; }
        [Required] [EmailAddress]
        public string email { get; set; }
        [Required]
        public string message { get; set; }
    }
}