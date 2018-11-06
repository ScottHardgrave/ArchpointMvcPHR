using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArchpointMvcPHR.Models
{
    public class SmokingHistoryRisk
    {
        public int SmokingHistRiskId { get; set; }

        [Display(Name = "Smoker?")]
        [StringLength(20, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string Smoker { get; set; }

        [Display(Name = "Age started smoking")]
        [DataType(DataType.Text)]
        public string AgeStarted { get; set; }

        [Display(Name = "Age quit smoking")]
        [DataType(DataType.Text)]
        public string AgeQuit { get; set; }

        [Display(Name = "Smokeless tobacco?")]
        [DataType(DataType.Text)]
        public string ChewingSmokelessTobacco { get; set; }

        [Display(Name = "Quitting Goal")]
        [DataType(DataType.Text)]
        public string QuittingGoal { get; set; }
    }
}
