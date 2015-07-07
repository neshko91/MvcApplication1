using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication1.Scripts.Models
{
    public class UserModel
    {
        [Required]
        public String Username { get; set; }
        [Required]
        public String Password { get; set; }
        
    }
}