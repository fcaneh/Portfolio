using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Portfolio.Models
{
    public class ContactMessage
    {
        [Required(ErrorMessage = "Le nom est obligatoire.")]
        public string Name { get; set; } = "";

        [Required(ErrorMessage = "L'email est obligatoire.")]
        [EmailAddress(ErrorMessage = "L'email n'est pas valide.")]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "Le message est obligatoire.")]
        [MinLength(10, ErrorMessage = "Le message doit contenir au moins 10 caractères.")]
        public string Message { get; set; } = "";
    }
}
