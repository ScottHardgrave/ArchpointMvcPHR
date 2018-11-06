using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArchpointMvcPHR.Models
{
    public class BloodPressureRisk
    {
        public int BloodPressureRiskId { get; set; }

        [Display(Name = "Date Record Stored")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DateDateEntered { get; set; }

        [Display(Name = "Systolic Pressure")]
        [StringLength(80, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string SystolicPressure { get; set; }

        [Display(Name = "Diastolic Pressure")]
        [StringLength(80, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string DiastolicPressure { get; set; }

        [Display(Name = "Pulse Rate")]
        [StringLength(80, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string PulseRate { get; set; }

        [Display(Name = "Date Blood Pressure Taken")]
        [DataType(DataType.Date)]
        public DateTime DateTaken { get; set; }

        [Display(Name = "Time Blood Pressure Taken")]
        [DataType(DataType.Time)]
        public TimeSpan TimeTaken { get; set; }

        [Display(Name = "Systolic Blood Pressure Goal")]
        [StringLength(80, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string SystolicBpgoal { get; set; }

        [Display(Name = "Diastolic Blood Pressure Goal")]
        [StringLength(80, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string DiastolicBpgoal { get; set; }

        public string Comments { get; set; }
    }
}
