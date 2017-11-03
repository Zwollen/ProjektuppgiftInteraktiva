using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjektuppgiftInteraktiva.Models.ViewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Du måste fylla i Användarnamn")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Du måste fylla i Lösenord")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}