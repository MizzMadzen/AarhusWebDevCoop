using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AarhusWebDevCoop.ViewModels
{
    public class ContactForm
    {
        [Required]
        public String Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "This is not a valid email address")]
        public String Email { get; set; }

        [Required]
        public String Subject { get; set; }

        [Required]
        public String Message { get; set; }
    }
}