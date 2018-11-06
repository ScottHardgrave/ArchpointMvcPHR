using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArchpointMvcPHR.Models
{
    public class WeightAndMeasurementRisk
    {
        public int WeightMeasurementRiskId { get; set; }

        [Display(Name = "Current Weight")]
        [DataType(DataType.Text)]
        public string Weight { get; set; }

        [Display(Name = "Date Taken")]
        [DataType(DataType.Date)]
        public DateTime DateTaken { get; set; }

        [Display(Name = "Weight Goal")]
        [DataType(DataType.Text)]
        public string WeightGoal { get; set; }

        [Display(Name = "Height")]
        [DataType(DataType.Text)]
        public string Height { get; set; }

        [Display(Name = "Body Mass Index")]
        [DataType(DataType.Text)]
        public string Bmi { get; set; }

        [Display(Name = "Current Waist Size")]
        [DataType(DataType.Text)]
        public string CurrentWaistSize { get; set; }

        [Display(Name = "Waist Size Goal")]
        [DataType(DataType.Text)]
        public string WaistSizeGoal { get; set; }

        public string Comments { get; set; }
    }
}
