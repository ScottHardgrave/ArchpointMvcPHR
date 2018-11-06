using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArchpointMvcPHR.Models
{
    public class StdHistory
    {
        public int StdHistoryId { get; set; }

        [Display(Name = "Type of STD")]
        [DataType(DataType.Text)]
        public string StdType { get; set; }

        [Display(Name = "Date of diagnosis")]
        [DataType(DataType.Date)]
        public DateTime StdDateOfDiagnosis { get; set; }

        [Display(Name = "Status")]
        [DataType(DataType.Text)]
        public string StdStatus { get; set; }

        [Display(Name = "Date Resolved")]
        [DataType(DataType.Date)]
        public DateTime StdDateResolved { get; set; }

        [Display(Name = "Any medications?")]
        [DataType(DataType.Text)]
        public string StdMedication { get; set; }

        public string Comments { get; set; }
    }
}
