using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArchpointMvcPHR.Models
{
    public class MedCareLocation
    {
        public int MedCareLocationId { get; set; }

        [Display(Name = "Street Address")]
        [DataType(DataType.Text)]
        public string LocationStreetAddress { get; set; }

        [Display(Name = "City")]
        [DataType(DataType.Text)]
        public string LocationCity { get; set; }

        [Display(Name = "State/Province")]
        [DataType(DataType.Text)]
        public string LocationStateProvince { get; set; }

        [Display(Name = "Zip Code")]
        [DataType(DataType.Text)]
        public string LocationZipCode { get; set; }

        [Display(Name = "Country")]
        [DataType(DataType.Text)]
        public string LocationCountry { get; set; }

        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string LocationPhoneNum { get; set; }

        [Display(Name = "Fax")]
        [DataType(DataType.Text)]
        public string LocationFax { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string LocationEmail { get; set; }

        [Display(Name = "Name of Location")]
        [DataType(DataType.Text)]
        public string LocationName { get; set; }
    }
}
