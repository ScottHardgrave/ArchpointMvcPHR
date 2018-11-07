using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArchpointMvcPHR.Models
{
    public class Immunizations
    {
        public int ImmunizationsId { get; set; }

        [Display(Name = "Type of immunization?")]
        [DataType(DataType.Text)]
        public string ImmunizationType { get; set; }

        [Display(Name = "Date received:")]
        [DataType(DataType.Date)]
        public DateTime DateReceived { get; set; }

        [Display(Name = "Admministering Medical Provider:")]
        [DataType(DataType.Text)]
        public string AdministeredBy { get; set; }

        [Display(Name = "Date of last tetanus shot")]
        [DataType(DataType.Date)]
        public DateTime DateLastTetanus { get; set; }

        public string Comments { get; set; }
    }
}
