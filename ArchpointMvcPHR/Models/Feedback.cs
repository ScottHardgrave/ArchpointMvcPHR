using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArchpointMvcPHR.Models
{
    public class Feedback
    {
        public int FeedbackId { get; set; }

        [Display(Name = "How did you find Archpoint?")]
        [DataType(DataType.Text)]
        public string HowArchpointWasFound { get; set; }

        [Display(Name = "Was the software east to understand?")]
        [DataType(DataType.Text)]
        public string EasyToUnderstand { get; set; }

        [Display(Name = "What are some suggestions for improvement?")]
        [DataType(DataType.Text)]
        public string SuggestionsForImprovements { get; set; }
    }
}
