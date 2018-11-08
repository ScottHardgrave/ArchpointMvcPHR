using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArchpointMvcPHR.Models
{
    public class Caregivers
    {
        public int CaregiversId { get; set; }

        [Display(Name = "First Name")]
        [StringLength(100, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string PatientFirstName { get; set; }

        [Display(Name = "M.I.")]
        [StringLength(1)]
        [Required]
        [DataType(DataType.Text)]
        public string PatientMiddleInitial { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(100, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string patientLastName { get; set; }

        [Display(Name = "Relationship to Patient")]
        [StringLength(60, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string RelationshipToPatient { get; set; }

        [Display(Name = "Street Address")]
        [StringLength(100, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string StreetAddress { get; set; }

        [StringLength(100, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string City { get; set; }

        [Display(Name = "State/Province")]
        [StringLength(100, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string StateProvince { get; set; }

        [Display(Name = "Zip Code")]
        [StringLength(25, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string ZipCode { get; set; }

        [StringLength(100, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string Country { get; set; }

        [Display(Name = "Phone Number")]
        [StringLength(25, MinimumLength = 1)]
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Display(Name = "Evening Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string EveningPhone { get; set; }

        [Display(Name = "Cell Number")]
        [DataType(DataType.PhoneNumber)]
        public string CellPhone { get; set; }

        [Display(Name = "Patient currently enrolled in a nursing facility?")]
        [StringLength(60, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string PatientCurrentlyInNursingFacility { get; set; }

    }
}
