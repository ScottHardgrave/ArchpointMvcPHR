using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArchpointMvcPHR.Models
{
    public class EyeHistory
    {
        public int EyeHistoryId { get; set; }

        public DateTime DateLastEyeExam { get; set; }

        public DateTime DateNextEyeExam { get; set; }

        public DateTime DateLastGlaucomaExam { get; set; }

        public DateTime DateNextGlaucomaExam { get; set; }

        public string MedicalProviderId { get; set; }

        public string Eyeglasses { get; set; }

        public string ContactLenses { get; set; }

        public DateTime PrescriptionDate { get; set; }

        public string ContactBrandName { get; set; }

        public string EyeDiseaseDisorder { get; set; }

        public DateTime EyeDiseaseDisorderDiagnosisDate { get; set; }

        public string EyeDiseaseDisorderStatus { get; set; }

        public DateTime EyeDiseaseDisorderResolveDate { get; set; }

        public string PreviousEyeSurgery { get; set; }

        public string EyeSurgeryProcedure { get; set; }

        public DateTime EyeSurgeryProcedureDate { get; set; }

        public string MedCareLocationId { get; set; }

        public string Comments { get; set; }

    }
}
