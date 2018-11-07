using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ArchpointMvcPHR.Models
{
    public class FamilyHistory
    {
        public int ID { get; set; }

        [Display(Name = "Family Member")]
        [StringLength(60, MinimumLength = 1)]
        public string FamilyMember { get; set; }

        /* public string Aunt { get; set; }
        public string Brother { get; set; }
        public string Cousin { get; set; }
        public string Daughter { get; set; }
        public string Granddaughter { get; set; }
        public string Grandmother { get; set; }
        public string Grandson { get; set; }
        public string Mother { get; set; }
        public string Nephew { get; set; }
        public string Niece { get; set; }
        public string Sister { get; set; }
        public string Son { get; set; }
        public string Uncle { get; set; }*/

        [Display(Name = "First Name")]
        [StringLength(100, MinimumLength = 1)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(100, MinimumLength = 1)]
        public string LastName { get; set; }

        [Required]
        public string Disease { get; set; }

        [Display(Name = "Cause Of Death ")]
        [StringLength(150, MinimumLength = 1)]
        public string CauseOfDeath { get; set; }

        [Display(Name = "Comments")]
        public string Comments { get; set; }


    }
}
