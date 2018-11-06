using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArchpointMvcPHR.Models
{
    public class EmergencyContact
    {
        public int Id { get; set; }

        [Display(Name = "First name")]
        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string FirstName { get; set; }


        [Display(Name = "Last Name")]
        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string LastName { get; set; }

        [Display(Name = "Relationship to patient")]
        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string RelationshipToPatient { get; set; }


        [Display(Name = "Day Phone Num")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(20, MinimumLength = 1)]
        public string HomePhone { get; set; }

        [Display(Name = "Evening Phone Num")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(20, MinimumLength = 1)]
        public string EveningPhone { get; set; }

        [Display(Name = "Cell Phone Num")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(20, MinimumLength = 1)]
        [Required]
        public string CellPhone { get; set; }


        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(80, MinimumLength = 1)]
        public string EmerContactEmail { get; set; }

        [Display(Name = "Street Address")]
        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string EmerContactStreetAddress { get; set; }

        [Display(Name = "City")]
        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string EmerContactCity { get; set; }

        [Display(Name = "State/Province")]
        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string EmerContactStateProvince { get; set; }

        [Display(Name = "Zip Code")]
        [StringLength(20, MinimumLength = 5)]
        [Required]
        public string EmerContactZip { get; set; }

        [Display(Name = "Country")]
        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string EmerContactCountry { get; set; }
    }
}
