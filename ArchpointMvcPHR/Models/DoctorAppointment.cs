using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArchpointMvcPHR.Models
{
    public class DoctorAppointment
    {
        public string Id { get; set; }

        [Display(Name = "Appointment Date")]
        [StringLength(80, MinimumLength = 1)]
        [Required]
        public DateTime ApptDate { get; set; }

        [Display(Name = "Medical Provider")]
        [StringLength(80, MinimumLength = 1)]
        [Required]
        public int MedicalProviderId { get; set; }

        [Display(Name = "Reason For Visit")]
        [StringLength(80, MinimumLength = 1)]
        [Required]
        public string ReasonForVisit { get; set; }

        [Display(Name = "Symptoms/Complaints")]
        [StringLength(80, MinimumLength = 1)]
        [Required]
        public string SymptomComplaint { get; set; }

        [Display(Name = "Facility Name")]
        [StringLength(80, MinimumLength = 1)]
        [Required]
        public string FacilityName { get; set; }

        [Display(Name = "Phone Number")]
        [StringLength(20, MinimumLength = 1)]
        [Required]
        public string Phone { get; set; }

        [Display(Name = "Fax")]
        [StringLength(40, MinimumLength = 1)]
        public string Fax { get; set; }

        [Display(Name = "Email")]
        [StringLength(80, MinimumLength = 1)]
        public string Email { get; set; }

        public string Comments { get; set; }

        [Display(Name = "Remind Me?")]
        [StringLength(5, MinimumLength = 1)]
        [Required]
        public string RemindMe { get; set; }


    }
}
