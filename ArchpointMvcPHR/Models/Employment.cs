using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArchpointMvcPHR.Models
{
    public class Employment
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        [StringLength(100, MinimumLength = 1)]
        [Required]
        public string EmployerName { get; set; }

        [Display(Name = "Street Address")]
        [StringLength(100, MinimumLength = 1)]
        [Required]
        public string Address { get; set; }

        [StringLength(80, MinimumLength = 1)]
        [Required]
        public string City { get; set; }

        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string State { get; set; }

        [Display(Name = "Zip/Postal code")]
        [StringLength(20, MinimumLength = 1)]
        [DataType(DataType.PostalCode)]
        [Required]
        public string ZipCode { get; set; }

        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string PhoneNum { get; set; }
    }
}
