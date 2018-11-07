using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArchpointMvcPHR.Models
{
    public class MensHealth
    {
        public int MensHealthId { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateLastAnnualPhysical { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateNextAnnualPhysical { get; set; }

        public string FamilyHistoryProstateCancer { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateLastProstateExam { get; set; }

        public string LastProstateExamResults { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateNextProstateExam { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateLastPsa { get; set; }

        public string LastPsaresults { get; set; }

        public int PsaLevelTestNumber { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateNextPsatest { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateLastFecalOccultTest { get; set; }

        public string FecalOccultResults { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateNextFecalOccultTest { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateLastSigmoidColonoscopyExam { get; set; }

        public string SigmoidColonoscopyResults { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateNextSigmoidColonoscopy { get; set; }

        public string MensHealthIssues { get; set; }

        public string Comments { get; set; }
    }
}
