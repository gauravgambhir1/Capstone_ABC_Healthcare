using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Healthcare_CapstoneProject_LMS.Data.ViewModels
{
    public class RegisterVM
    {
        [Display(Name = "FullName")]
        [Required(ErrorMessage = "FullName is Required")]
        public string FullName { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage ="Email is Required")]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

      
    }// V.88
}
