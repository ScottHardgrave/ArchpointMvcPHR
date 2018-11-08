using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArchpointMvcPHR.Models
{
    public class EarNoseThroatHistory
    {
        public int EarNoseThroatHistoryId { get; set; }

        [Display(Name = "Disease/Disorder")]
        [StringLength(60, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string DiseaseDisorder { get; set; }

        [Display(Name = "Date of diagnosis")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DiagnosisDate { get; set; }

        [Display(Name = "Current status")]
        [StringLength(60, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string CurrentStatus { get; set; }

        [Display(Name = "Date resolved")]
        [DataType(DataType.Date)]
        public DateTime DateResolved { get; set; }

        [Required]
        public int MedicalProviderId { get; set; }

        [Required]
        public int MedCareLocationId { get; set; }

        [Required]
        public string Surgery { get; set; }

        
    }
}
