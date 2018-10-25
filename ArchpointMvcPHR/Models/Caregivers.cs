using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ArchpointMvcPHR.Models
{
    public class Caregivers
    {
        public int Id { get; set; }

        [Display(Name ="First Name")]
        [StringLength(60, MinimumLength = 15)]
        [Required]
        public string FirstName { get; set; }

        [Display(Name ="Last Name")]
        [StringLength(60, MinimumLength = 15)]
        [Required]
        public string LastName { get; set; }

        [Display(Name = "M.I.")]
        [StringLength(1)]
        public char MiddleInitial { get; set; }

        [StringLength(60, MinimumLength = 15)]
        [Required]
        public string Relationship { get; set; }    //to the patient

        [Required]
        public string Address { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        [StringLength(2)]
        public string State { get; set; }   //Create a select drop down menu; use abbreviations, like LA or TX

        [Display(Name = "Zip Code")]
        [StringLength(5)]
        public string ZipCode { get; set; }

        [Required]
        public string Country { get; set; }

        [Display(Name = "Cell Phone")]
        [StringLength(10)]
        [Required]
        public string CellPhone { get; set; }

        [Display(Name = "Work Phone")]
        [StringLength(10)]
        [Required]
        public string WorkPhone { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }
    }
}
