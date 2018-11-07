using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArchpointMvcPHR.Models
{
    public class EarNoseThroatHistory
    {
        public int EarNoseThroatHistoryId { get; set; }

        public string DiseaseDisorder { get; set; }

        public DateTime DiagnosisDate { get; set; }

        public string CurrentStatus { get; set; }

        public DateTime DateResolved { get; set; }

        public int MedicalProviderId { get; set; }

        public int MedCareLocationId { get; set; }

        public string Surgery { get; set; }

        
    }
}
