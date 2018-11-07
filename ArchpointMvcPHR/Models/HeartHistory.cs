using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArchpointMvcPHR.Models
{
    public class HeartHistory
    {
        public int HeartHistoryId { get; set; }

        public int MedicalProviderId { get; set; }

        public string HeartDiseaseDisorder { get; set; }

        public DateTime DiagnosisDate { get; set; }

        public string DiagnosisStatus { get; set; }

        public DateTime DateResolved { get; set; }

        public string Comments { get; set; }

    }
}
