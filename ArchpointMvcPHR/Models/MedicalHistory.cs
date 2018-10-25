using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArchpointMvcPHR.Models
{
    public class MedicalHistory
    {
        public int Id { get; set; }

        [Display(Name = "Disease/Disorder")]
        [StringLength(80, MinimumLength = 1)]
        [Required]
        public string DiseaseDisorder { get; set; }

        [Display(Name = "Date of diagnosis")]
        [StringLength(80, MinimumLength = 1)]
        [Required]
        public DateTime DateOfDiagnosis { get; set; }

        [Display(Name = "Age at onset")]
        [StringLength(10, MinimumLength = 1)]
        [Required]
        public string AgeAtOnset { get; set; }


        [StringLength(80, MinimumLength = 1)]
        [Required]
        public string Status { get; set; }

        [Display(Name = "Date Resolved")]
        [StringLength(80, MinimumLength = 1)]
        [Required]
        public DateTime DateResolved { get; set; }

        [Display(Name = "Treating Physician")]
        [StringLength(80, MinimumLength = 1)]
        [Required]
        public string MedicalProviderId { get; set; }


        [StringLength(500, MinimumLength = 1)]
        public string Comments { get; set; }


    }
}
