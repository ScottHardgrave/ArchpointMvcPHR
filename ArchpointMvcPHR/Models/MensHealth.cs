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

        [Display(Name = "Date Last Physical")]
        [DataType(DataType.Date)]
        public DateTime DateLastAnnualPhysical { get; set; }

        [Display(Name = "Date Next Physical")]
        [DataType(DataType.Date)]
        public DateTime DateNextAnnualPhysical { get; set; }

        [Display(Name = "Family History Of Prostate Cancer?")]
        public string FamilyHistoryProstateCancer { get; set; }

        [Display(Name = "Date Last Prostate Exam")]
        [DataType(DataType.Date)]
        public DateTime DateLastProstateExam { get; set; }

        [Display(Name = "Last Prostate Exam Results")]
        public string LastProstateExamResults { get; set; }

        [Display(Name = "Date Next Prostate Exam")]
        [DataType(DataType.Date)]
        public DateTime DateNextProstateExam { get; set; }

        [Display(Name = "Date of Last PSA")]
        [DataType(DataType.Date)]
        public DateTime DateLastPsa { get; set; }

        [Display(Name = "Last PSA Results")]
        public string LastPsaresults { get; set; }

        [Display(Name = "PSA Level Test Number")]
        public int PsaLevelTestNumber { get; set; }

        [Display(Name = "Date of Next PSA Test")]
        [DataType(DataType.Date)]
        public DateTime DateNextPsatest { get; set; }

        [Display(Name = "Date of Last Fecal Occult Test")]
        [DataType(DataType.Date)]
        public DateTime DateLastFecalOccultTest { get; set; }

        [Display(Name = "Fecal Occult Test Resukts")]
        public string FecalOccultResults { get; set; }

        [Display(Name = "Date of next Fecal Occult Test")]
        [DataType(DataType.Date)]
        public DateTime DateNextFecalOccultTest { get; set; }

        [Display(Name = "Date of Last Sigmoid Colonoscopy Exam")]
        [DataType(DataType.Date)]
        public DateTime DateLastSigmoidColonoscopyExam { get; set; }

        [Display(Name = "Sigmoid Colonoscopy Results")]
        public string SigmoidColonoscopyResults { get; set; }

        [Display(Name = "Date of Next Sigmoid Colonoscopy")]
        [DataType(DataType.Date)]
        public DateTime DateNextSigmoidColonoscopy { get; set; }

        [Display(Name = "Mens Health Issues")]
        public string MensHealthIssues { get; set; }

        public string Comments { get; set; }
    }
}
