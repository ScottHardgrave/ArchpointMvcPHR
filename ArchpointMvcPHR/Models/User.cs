using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArchpointMvcPHR.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Display(Name = "First Name")]
        [StringLength(80, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string UserFirstName { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(80, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string UserLastName { get; set; }

        [Display(Name = "Password")]
        [StringLength(20, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "email address")]
        [StringLength(80, MinimumLength = 1)]
        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        /*
        [Display(Name = "Username")]
        [StringLength(80, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string Username { get; set; }
        */

        [Display(Name = "Relationship To Patient")]
        [StringLength(80, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string RelationshipToPatient { get; set; }
    }
}
