using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArchpointMvcPHR.Models
{
    public class MedicalProvider
    {
        public int Id { get; set; }


        [Display(Name = "Primary Physician?")]
        [StringLength(20, MinimumLength = 1)]
        [Required]
        public string PrimaryOrNot { get; set; }

        [Display(Name = "Active?")]
        [StringLength(20, MinimumLength = 1)]
        [Required]
        public string ActiveOrInactive { get; set; }

        [Display(Name = "First name")]
        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last name")]
        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string LastName { get; set; }

        [Display(Name = "Type Of Specialty")]
        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string TypeOfSpecialty { get; set; }

        [Display(Name = "Street Address")]
        [StringLength(80, MinimumLength = 1)]
        [Required]
        public string StreetAddress { get; set; }

        [Display(Name = "City")]
        [StringLength(80, MinimumLength = 1)]
        [Required]
        public string City { get; set; }

        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string State { get; set; }

        [Display(Name = "Zip Code")]
        [StringLength(20, MinimumLength = 1)]
        [Required]
        public string ZipCode { get; set; }

        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string Country { get; set; }

        [Display(Name = "Phone Num")]
        [StringLength(20, MinimumLength = 1)]
        [Required]
        public string Phone { get; set; }

        [Display(Name = "Fax")]
        [StringLength(40, MinimumLength = 1)]
        public string Fax { get; set; }

        [Display(Name = "Email")]
        [StringLength(80, MinimumLength = 1)]
        public string Email { get; set; }
    }
}
