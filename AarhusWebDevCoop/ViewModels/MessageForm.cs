using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AarhusWebDevCoop.ViewModels
{
    public class MessageForm
    {
        [Required(ErrorMessage = "The Name field is required.")]
        public String mesName { get; set; }

        [Required(ErrorMessage = "The Email field is required.")]
        [EmailAddress(ErrorMessage = "This is not a valid email address")]
        public String mesEmail { get; set; }

        [Required(ErrorMessage = "The Title field is required.")]
        public String mesTitle { get; set; }

        [Required(ErrorMessage = "The Message field is required.")]
        public String mesMessage { get; set; }
    }
}