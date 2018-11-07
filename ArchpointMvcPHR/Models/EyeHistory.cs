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

        [DataType(DataType.Date)]
        public DateTime DateLastEyeExam { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateNextEyeExam { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateLastGlaucomaExam { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateNextGlaucomaExam { get; set; }

        [Required]
        public int MedicalProviderId { get; set; }

        [StringLength(60, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string Eyeglasses { get; set; }

        [StringLength(60, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string ContactLenses { get; set; }

        [DataType(DataType.Date)]
        public DateTime PrescriptionDate { get; set; }

        [StringLength(60, MinimumLength = 1)]
        [DataType(DataType.Text)]
        public string ContactBrandName { get; set; }

        [StringLength(60, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string EyeDiseaseDisorder { get; set; }

        [DataType(DataType.Date)]
        public DateTime EyeDiseaseDisorderDiagnosisDate { get; set; }

        [StringLength(60, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string EyeDiseaseDisorderStatus { get; set; }

        [DataType(DataType.Date)]
        public DateTime EyeDiseaseDisorderResolveDate { get; set; }

        [StringLength(60, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string PreviousEyeSurgery { get; set; }

        [StringLength(100, MinimumLength = 1)]
        [DataType(DataType.Text)]
        public string EyeSurgeryProcedure { get; set; }

        [DataType(DataType.Date)]
        public DateTime EyeSurgeryProcedureDate { get; set; }

        [Required]
        public string MedCareLocationId { get; set; }

        public string Comments { get; set; }

    }
}
