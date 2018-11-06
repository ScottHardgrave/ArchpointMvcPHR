using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArchpointMvcPHR.Models
{
    public class DiabetesRisk
    {
        public int DiabetesRiskId { get; set; }

        [Display(Name = "Date Taken")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateTaken { get; set; }

        [Display(Name = "Level Before Breakfast")]
        [StringLength(100, MinimumLength = 1)]
        [DataType(DataType.Text)]
        public string LevelBeforeBreakfast { get; set; }

        [Display(Name = "Level After breakfast")]
        [StringLength(100, MinimumLength = 1)]
        [DataType(DataType.Text)]
        public string LevelAfterBreakfast { get; set; }

        [Display(Name = "Level Before Lunch")]
        [StringLength(100, MinimumLength = 1)]
        [DataType(DataType.Text)]
        public string LeverlBeforeLunch { get; set; }

        [Display(Name = "Level After Lunch")]
        [StringLength(100, MinimumLength = 1)]
        [DataType(DataType.Text)]
        public string LevelAfterLunch { get; set; }

        [Display(Name = "Level Before Dinner")]
        [StringLength(100, MinimumLength = 1)]
        [DataType(DataType.Text)]
        public string LevelBeforeDinner { get; set; }

        [Display(Name = "Level After Dinner")]
        [StringLength(100, MinimumLength = 1)]
        [DataType(DataType.Text)]
        public string LevelAfterDinner { get; set; }

        [Display(Name = "Level At Bedtime")]
        [StringLength(100, MinimumLength = 1)]
        [DataType(DataType.Text)]
        public string LevelAtBedtime { get; set; }

        [Display(Name = "Medications?")]
        [StringLength(100, MinimumLength = 1)]
        [DataType(DataType.Text)]
        public string Medications { get; set; }

        [Display(Name = "Target Glucose Before Meal: Lowest Acceptable")]
        [StringLength(100, MinimumLength = 1)]
        [DataType(DataType.Text)]
        public string TargertGlucoseBeforeMealLow { get; set; }

        [Display(Name = "Target Glucose After Meal: Highest Acceptable")]
        [StringLength(100, MinimumLength = 1)]
        [DataType(DataType.Text)]
        public string TargetGlucoseAfterMealHigh { get; set; }

        [Display(Name = "Target Glucose Range After Meal: Lowest")]
        [StringLength(100, MinimumLength = 1)]
        [DataType(DataType.Text)]
        public string TargetGlucoseRangeAfterMealLow { get; set; }

        [Display(Name = "Target Glucose Range After Meal: Highest")]
        [StringLength(100, MinimumLength = 1)]
        [DataType(DataType.Text)]
        public string TargetGlucoseRangeAfterMealHigh { get; set; }

        [Display(Name = "How long of a span did this occur over?")]
        [StringLength(100, MinimumLength = 1)]
        [DataType(DataType.Text)]
        public string DateSpan { get; set; }

        public string Comments { get; set; }
    }
}
