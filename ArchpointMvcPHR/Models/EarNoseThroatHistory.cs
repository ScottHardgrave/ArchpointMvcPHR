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

        [StringLength(60, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string DiseaseDisorder { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime DiagnosisDate { get; set; }

        [StringLength(60, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string CurrentStatus { get; set; }

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
