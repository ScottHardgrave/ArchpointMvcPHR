using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArchpointMvcPHR.Models
{
    public class AsthmaRisk
    {
        public int AsthmaRiskId { get; set; }

        [Display(Name = "Hospitalized?")]
        [StringLength(60, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string AsthmaHospitalization { get; set; }

        [Display(Name = "Date")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime AsthmaHospitalizationDate { get; set; }

        [Display(Name = "ICU Required?")]
        [StringLength(60, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string AsthmaIcu { get; set; }

        [Display(Name = "ICU Admittance Date")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime IcuAdmitDate { get; set; }

        [Display(Name = "Triggers")]
        [StringLength(60, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string AsthmaTriggers { get; set; }

        [Display(Name = "Symptoms")]
        [StringLength(60, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string AsthmaSymptoms { get; set; }

        [Display(Name = "Severity")]
        [StringLength(60, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string AsthmaSeverity { get; set; }

        [Display(Name = "Medication")]
        [StringLength(60, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string MedicationForAsthma { get; set; }

        [Display(Name = "Medication Name")]
        [StringLength(60, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string MedicationName { get; set; }

        public string Comments { get; set; }
    }
}
