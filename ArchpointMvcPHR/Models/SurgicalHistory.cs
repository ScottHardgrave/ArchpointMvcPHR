using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArchpointMvcPHR.Models
{
    public class SurgicalHistory
    {
        public int SurgeryHistoryId { get; set; }

        [Display(Name = "Surgery Procedure")]
        [StringLength(80, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string SurgeryProcedure { get; set; }

        [Display(Name = "Date of Procedure")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfSurgeryProcedure { get; set; }

        [Display(Name = "Medical Provider")]
        [StringLength(80, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string MedProviderId { get; set; }

        [Display(Name = "Medical Care Location")]
        [StringLength(80, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string MedCareLocationId { get; set; }

        [Display(Name = "Any problems with anesthesia?")]
        [StringLength(80, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string ProblemWithAnesthesia { get; set; }

        [Display(Name = "If so, explain")]
        [DataType(DataType.Text)]
        public string AnesthesiaProblemExplanation { get; set; }

    }
}
