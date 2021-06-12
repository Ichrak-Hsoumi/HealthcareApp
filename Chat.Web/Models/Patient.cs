using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chat.Web.Models
{
    public class Patient
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public string Age { get; set; }

        public string ville { get; set; }

        public Patient()
        {

        }
    }
}
