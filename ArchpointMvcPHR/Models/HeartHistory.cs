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

        [StringLength(100, MinimumLength = 1)]
        [DataType(DataType.Text)]
        [Required]
        public string HeartDiseaseDisorder { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime DiagnosisDate { get; set; }

        [StringLength(80, MinimumLength = 1)]
        [DataType(DataType.Text)]
        [Required]
        public string DiagnosisStatus { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateResolved { get; set; }

        public string Comments { get; set; }

    }
}
