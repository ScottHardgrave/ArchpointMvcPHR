using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArchpointMvcPHR.Models
{
    public class A1CTestRisk
    {
        public int A1cTestRiskId { get; set; }

        [Display(Name = "Date Entered")]
        [DataType(DataType.Date)]
        public DateTime DateEntered { get; set; }

        [Display(Name = "Date Tested")]
        [DataType(DataType.Date)]
        public DateTime DateTested { get; set; }

        [Display(Name = "Results")]
        [StringLength(60, MinimumLength = 1)]
        [DataType(DataType.Text)]
        public string A1cTestResults { get; set; }

        [Display(Name = "Target Range Goal")]
        [StringLength(60, MinimumLength = 1)]
        [DataType(DataType.Text)]
        public string A1cTargetRangeGoal { get; set; }


        public string Comments { get; set; }
    }
}
