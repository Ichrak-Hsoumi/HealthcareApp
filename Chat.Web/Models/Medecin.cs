using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Chat.Web.Models
{
    public class Medecin : Utilisateur
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Entrer le code cnam")]
        [Display(Name = "Code CNAM")]
        public string CodeCnam { get; set; }

        public Boolean Disponibilite { get; set; }

        [Required(ErrorMessage = "Entrer l'expérience")]
        public string Experience { get; set; }

        [Required(ErrorMessage = "Entrer la spécialité")]
        public string Specialite { get; set; }



        [Required(ErrorMessage = "Entrer l'université")]
        public string Universite { get; set; }



        public Medecin()
        {

        }
    }
}
