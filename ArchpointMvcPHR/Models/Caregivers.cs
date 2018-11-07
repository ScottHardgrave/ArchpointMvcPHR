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

        [StringLength(100, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string PatientFirstName { get; set; }

        [StringLength(1)]
        [Required]
        [DataType(DataType.Text)]
        public string PatientMiddleInitial { get; set; }

        [StringLength(100, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string patientLastName { get; set; }

        [StringLength(60, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string RelationshipToPatient { get; set; }

        [StringLength(100, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string StreetAddress { get; set; }

        [StringLength(100, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string City { get; set; }

        [StringLength(100, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string StateProvince { get; set; }

        [StringLength(25, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string ZipCode { get; set; }

        [StringLength(100, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string Country { get; set; }

        [StringLength(25, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string PhoneNumber { get; set; }

        public string EveningPhone { get; set; }

        public string CellPhone { get; set; }

        [StringLength(60, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string PatientCurrentlyInNursingFacility { get; set; }

    }
}
