using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArchpointMvcPHR.Models
{
    public class TestsExams
    {
        public int TestsExamsId { get; set; }

        [Display(Name = "Test/Exam given")]
        [StringLength(80, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string TestExamType { get; set; }

        [Display(Name = "Result")]
        [StringLength(80, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string TestExamResult { get; set; }

        [Display(Name = "Date of test/exam given")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfTestExam { get; set; }

        [Display(Name = "Reason")]
        [StringLength(80, MinimumLength = 1)]
        [Required]
        [DataType(DataType.Text)]
        public string ReaonForTestExam { get; set; }

        [Display(Name = "Medical care Location")]
        [Required]
        [DataType(DataType.Text)]
        public string MedCareLocationId { get; set; }
    }
}
