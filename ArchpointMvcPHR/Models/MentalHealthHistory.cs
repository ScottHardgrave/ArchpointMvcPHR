using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArchpointMvcPHR.Models
{
    public class MentalHealthHistory
    {
        public int MentalHealthHistoryid { get; set; }

        [Display(Name = "Current Treatment")]
        [StringLength(100, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string CurrentTreatmentForMentalDisorder { get; set; }

        [Required]
        public int MedCareLocationId { get; set; }

        [Display(Name = "Type of Treatment")]
        [StringLength(100, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string TypeOfTreatment { get; set; }

        [Display(Name = "Treated in Past?")]
        [StringLength(20, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string TreatedInPast { get; set; }

        [Display(Name = "Mental Condition/Disorder")]
        [StringLength(100, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string MentalConditionDisorder { get; set; }

        [Display(Name = "Current Medication")]
        [StringLength(100, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string CurrentMedication { get; set; }

        [Required]
        public int MedicalProviderId { get; set; }

        public string Comments { get; set; }

    }
}
