using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Chat.Web.Models
{
    public class ForgetPassword
    {
        [Required, EmailAddress, Display(Name = "Registred email adresse")]
        public string email { get; set; }
    }
}
