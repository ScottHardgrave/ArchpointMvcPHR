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

        [Required]
        public string MedProviderId { get; set; }

        [StringLength(60, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string TypeOfCancerTumor { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DiagnosisDate { get; set; }

        [StringLength(3, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string AgeAtDiagnosis { get; set; }

        [StringLength(20, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string StageOfCancerTumor { get; set; }

        [Required]
        public string MedCareLocationId { get; set; }

        [StringLength(255, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string TreatmentReceived { get; set; }


        [Required]
        [DataType(DataType.Date)]
        public DateTime TreatmentDate { get; set; }

        public string Comments { get; set; }

    }
}
