using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArchpointMvcPHR.Models
{
    public class AlcoholRisk
    {
        public int AlcoholRiskId { get; set; }

        [Display(Name = "Drink Alcohol?")]
        [StringLength(40, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string DrinkAlc { get; set; }

        [Display(Name = "Daily Drink Count")]
        [DataType(DataType.Text)]
        public string DailyDrinkCount { get; set; }

        [Display(Name = "Weekend Drink Count")]
        [DataType(DataType.Text)]
        public string WeekendDrinkCount { get; set; }

        [Display(Name = "Social Drink Count")]
        [DataType(DataType.Text)]
        public string SocialDrinkCount { get; set; }

        [Display(Name = "Years since quit drinking")]
        [DataType(DataType.Text)]
        public string YearsQuitDrinking { get; set; }

        [Display(Name = "Been treated for alcohol abuse?")]
        [DataType(DataType.Text)]
        public string TreatedForAlcAbuse { get; set; }

        [Display(Name = "Year Treated")]
        [DataType(DataType.Date)]
        public DateTime YearTreated { get; set; }

        [Display(Name = "Length of treatment")]
        [DataType(DataType.Text)]
        public string LengthOfTreatment { get; set; }

        [Display(Name = "Type of treatment")]
        [DataType(DataType.Text)]
        public string TypeOfTreatment { get; set; }

        public string Comments { get; set; }
    }
}
