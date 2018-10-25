using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ArchpointMvcPHR.Models
{
    public class FamilyHistory
    {
        public int Id { get; set; }
        
        [Display(Name = "First Name")]
        [StringLength(60, MinimumLength = 15)]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(60, MinimumLength = 15)]
        [Required]
        public string LastName { get; set; }


        public string MemberType { get; set; }  //like an aunt or uncle
        public int Age { get; set; }
        public string Disease { get; set; }
        public string Comment { get; set; }



    }
}
