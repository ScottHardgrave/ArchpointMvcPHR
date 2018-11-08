using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArchpointMvcPHR.Models
{
    public class CancerHistory
    {
        public int CancerHistoryId {get; set;}

        [Display(Name = "Medical Provider")]
        [Required]
        public int MedProviderId { get; set; }

        [Display(Name = "Type of Cancer/Tumor")]
        [StringLength(60, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string TypeOfCancerTumor { get; set; }

        [Display(Name = "Date of Diagnosis")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime DiagnosisDate { get; set; }

        [Display(Name = "Age at Diagnosis")]
        [StringLength(3, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string AgeAtDiagnosis { get; set; }

        [Display(Name = "Stage of Cancer/Tumor")]
        [StringLength(20, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string StageOfCancerTumor { get; set; }

        [Required]
        public string MedCareLocationId { get; set; }

        [Display(Name = "Treatment Received")]
        [StringLength(255, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string TreatmentReceived { get; set; }

        [Display(Name = "Treatment Date")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime TreatmentDate { get; set; }

        public string Comments { get; set; }

    }
}
