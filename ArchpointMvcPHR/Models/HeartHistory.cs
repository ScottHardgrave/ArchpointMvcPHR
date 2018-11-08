using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArchpointMvcPHR.Models
{
    public class HeartHistory
    {
        public int HeartHistoryId { get; set; }

        [Required]
        public int MedicalProviderId { get; set; }

        [Display(Name = "Heart Disease/Disorder")]
        [StringLength(100, MinimumLength = 1)]
        [DataType(DataType.Text)]
        [Required]
        public string HeartDiseaseDisorder { get; set; }

        [Display(Name = "Diagnosis Date")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DiagnosisDate { get; set; }

        [Display(Name = "Status")]
        [StringLength(80, MinimumLength = 1)]
        [DataType(DataType.Text)]
        [Required]
        public string DiagnosisStatus { get; set; }

        [Display(Name = "Date Resolved")]
        [DataType(DataType.Date)]
        public DateTime DateResolved { get; set; }

        public string Comments { get; set; }

    }
}
