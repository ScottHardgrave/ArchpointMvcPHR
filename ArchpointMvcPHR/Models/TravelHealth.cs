using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArchpointMvcPHR.Models
{
    public class TravelHealth
    {
        public int TravelHealthId { get; set; }

        [Display(Name = "Country visited:")]
        [StringLength(80, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string CountryVisited { get; set; }

        [Display(Name = "Date visited:")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateVisited { get; set; }

        [Display(Name = "Disease/Illness contracted:")]
        [StringLength(80, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string DiseaseIllnessContracted { get; set; }

        [Display(Name = "Date contracted:")]
        [Required]
        public DateTime DateContracted { get; set; }

        public string Comments { get; set; }
    }
}
