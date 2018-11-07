using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArchpointMvcPHR.Models
{
    public class CancerHistory
    {
        public int CancerHistoryId {get; set;}

        public string MedProviderId { get; set; }

        public string TypeOfCancerTumor { get; set; }

        public DateTime DiagnosisDate { get; set; }

        public string AgeAtDiagnosis { get; set; }

        public string StageOfCancerTumor { get; set; }

        public string MedCareLocationId { get; set; }

        public string TreatmentReceived { get; set; }

        public DateTime TreatmentDate { get; set; }

        public string Comments { get; set; }

    }
}
