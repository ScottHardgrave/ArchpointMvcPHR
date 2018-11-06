using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArchpointMvcPHR.Models
{
    public class CholesterolRisk
    {
        public int CholesterolRiskId { get; set; }

        [Display(Name = "Date Cholesterol Taken")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateCholTaken { get; set; }

        [Display(Name = "Total Cholesterol Level")]
        [StringLength(80, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string TotalCholesterol { get; set; }

        [Display(Name = "LDL Cholesterol Level")]
        [StringLength(80, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string LdlCholesterol { get; set; }

        [Display(Name = "HDL Cholesterol Level")]
        [StringLength(80, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string HdlCholesterol { get; set; }

        [Display(Name = "Triglycerides")]
        [StringLength(80, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string Triglycerides { get; set; }

        [Display(Name = "Taken After Fasting?")]
        [StringLength(80, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string TakenAfterFasting { get; set; }

        [Display(Name = "Total Cholesterol Goal")]
        [DataType(DataType.Text)]
        public string TotalCholGoal { get; set; }

        [Display(Name = "LDL Cholesterol Goal")]
        [DataType(DataType.Text)]
        public int LdlCholGoal { get; set; }

        [Display(Name = "HDL Cholesterol Goal")]
        [DataType(DataType.Text)]
        public string HdlCholGoal { get; set; }

        [Display(Name = "Triglyceride Goal")]
        [DataType(DataType.Text)]
        public string TriglycerideGoal { get; set; }


        public string Comments { get; set; }
    }
}
