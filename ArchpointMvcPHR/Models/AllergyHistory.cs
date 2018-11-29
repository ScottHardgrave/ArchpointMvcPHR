using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArchpointMvcPHR.Models
{
    public class AllergyHistory
    {
        public int AllergyHistoryId { get; set; }

        [Display(Name = "Allergen")]
        [StringLength(80, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string DrugAllergen { get; set; }

        [Display(Name = "Results")]
        [StringLength(80, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string ContactAllergen { get; set; }

        [Display(Name = "Insect Bites/Sting")]
        [StringLength(80, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string InsectStingBites { get; set; }

        [Display(Name = "Airborne Inhaled Allergen")]
        [StringLength(80, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string AirborneInhaledAllergen { get; set; }

        [Display(Name = "Type Of Reaction")]
        [StringLength(80, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string TypeOfReaction { get; set; }

        [StringLength(80, MinimumLength = 1)]
        [Required]
        public string Severity { get; set; }

        [StringLength(80, MinimumLength = 1)]
        [Required]
        public string Symptoms { get; set; }

        [Display(Name = "Was medical treatment required?")]
        [StringLength(80, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string MedTreatmentRequired { get; set; }

        public string Comments { get; set; }
    }
}
