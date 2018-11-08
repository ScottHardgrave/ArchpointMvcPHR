using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArchpointMvcPHR.Models
{
    public class EyeHistory
    {
        public int EyeHistoryId { get; set; }

        [Display(Name = "Date of last eye exam")]
        [DataType(DataType.Date)]
        public DateTime DateLastEyeExam { get; set; }

        [Display(Name = "Date of next eye exam")]
        [DataType(DataType.Date)]
        public DateTime DateNextEyeExam { get; set; }

        [Display(Name = "Date of last glaucoma exam")]
        [DataType(DataType.Date)]
        public DateTime DateLastGlaucomaExam { get; set; }

        [Display(Name = "Date of next glaucoma exam")]
        [DataType(DataType.Date)]
        public DateTime DateNextGlaucomaExam { get; set; }

        [Required]
        public int MedicalProviderId { get; set; }

        [StringLength(60, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string Eyeglasses { get; set; }

        [Display(Name = "Contact Lenses")]
        [StringLength(60, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string ContactLenses { get; set; }

        [Display(Name = "Prescription Date")]
        [DataType(DataType.Date)]
        public DateTime PrescriptionDate { get; set; }

        [Display(Name = "Contact Brand Name")]
        [StringLength(60, MinimumLength = 1)]
        [DataType(DataType.Text)]
        public string ContactBrandName { get; set; }

        [Display(Name = "Eye Disease/Disorder")]
        [StringLength(60, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string EyeDiseaseDisorder { get; set; }

        [Display(Name = "Diagnosis date")]
        [DataType(DataType.Date)]
        public DateTime EyeDiseaseDisorderDiagnosisDate { get; set; }

        [Display(Name = "Status of eye disease/disorder")]
        [StringLength(60, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string EyeDiseaseDisorderStatus { get; set; }

        [Display(Name = "Date resolved")]
        [DataType(DataType.Date)]
        public DateTime EyeDiseaseDisorderResolveDate { get; set; }

        [Display(Name = "Previous eye surgery?")]
        [StringLength(60, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string PreviousEyeSurgery { get; set; }

        [Display(Name = "Type of eye surgery")]
        [StringLength(100, MinimumLength = 1)]
        [DataType(DataType.Text)]
        public string EyeSurgeryProcedure { get; set; }

        [Display(Name = "Date of eye surgery")]
        [DataType(DataType.Date)]
        public DateTime EyeSurgeryProcedureDate { get; set; }

        [Required]
        public string MedCareLocationId { get; set; }

        public string Comments { get; set; }

    }
}
