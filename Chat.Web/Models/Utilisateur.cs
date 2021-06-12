using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Chat.Web.Models
{
    public abstract class Utilisateur
    {
        [Required(ErrorMessage = "Entrer le nom")]
        public string nom { get; set; }

        [Required(ErrorMessage = "Entrer le prénom")]
        [Display(Name = "Prénom")]
        public string prenom { get; set; }

        [Required(ErrorMessage = "Entrer l'age")]
        public int age { get; set; }

        [Required(ErrorMessage = "Entrer l'adresse")]
        public string Adresse { get; set; }

        [Required(ErrorMessage = "Entrer l'email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Entrer la password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required(ErrorMessage = "Entrer le numéro de téléphone")]
        [Display(Name = "Numéro de téléphone")]
        [DataType(DataType.PhoneNumber)]
        public int Tel { get; set; }
    }
}
