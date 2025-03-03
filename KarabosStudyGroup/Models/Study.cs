using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KarabosStudyGroup.Models
{
    public class Study
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name")]
        [Display(Name = "Last Name")]

        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [Display(Name = "Email Address")]

        public string Email { get; set; }

        [Required(ErrorMessage ="Please enter your student number")]
        [Display(Name = "Student Number")]

        public string StudentNumber { get; set; }
    }
}