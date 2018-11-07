using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArchpointMvcPHR.Models
{
    public class PersonalInfo
    {
        public int Id { get; set; }

        [Display(Name = "First name")]
        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "M.I.")]
        [StringLength(1)]
        [Required]
        public string MiddleInitial { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string LastName { get; set; }

        [StringLength(20, MinimumLength = 1)]
        [Required]
        public string Sex { get; set; }

        [Display(Name = "Blood Type")]
        [StringLength(10, MinimumLength = 1)]
        [Required]
        public string BloodType { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "SSN")]
        [StringLength(11, MinimumLength = 9)]
        [Required]
        public string SocialSecurityNum { get; set; }

        [Display(Name = "Street Address")]
        [StringLength(100, MinimumLength = 1)]
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
        [DataType(DataType.PostalCode)]
        [Required]
        public string ZipCode { get; set; }

        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string Country { get; set; }

        [Display(Name = "Home Phone #")]
        [StringLength(20, MinimumLength = 1)]
        [DataType(DataType.PhoneNumber)]
        public string HomePhone { get; set; }

        [Display(Name = "Cell Phone #")]
        [StringLength(20, MinimumLength = 1)]
        [DataType(DataType.PhoneNumber)]
        [Required]
        public string CellPhone { get; set; }

        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string Race { get; set; }

        [Display(Name = "Marital Status")]
        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string MaritalStatus { get; set; }

        [StringLength(80, MinimumLength = 1)]
        public string Religion { get; set; }

    }
}
