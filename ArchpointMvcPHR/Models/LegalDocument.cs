using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArchpointMvcPHR.Models
{
    public class LegalDocument
    {
        public int ID { get; set; }

        [StringLength(3, MinimumLength = 2)]
        [Required]
        public string Will { get; set; }

        [Display(Name = "Date signed:")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [StringLength(60, MinimumLength = 5)]
        public DateTime WillDateSigned { get; set; }

        [Display(Name = "Last Updated:")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [StringLength(60, MinimumLength = 5)]
        public DateTime WillLastUpdated { get; set; }

        [Display(Name = "Copy On File")]
        [StringLength(3, MinimumLength = 1)]
        public string WillCopy { get; set; }

        [Display(Name = "Family Aware Of Instructions")]
        [StringLength(3, MinimumLength = 1)]
        public string FamilyAware { get; set; }

        [Display(Name = "Medical Power of Attorney")]
        [StringLength(3, MinimumLength = 1)]
        [Required]
        public string MedPowerOfAttorney { get; set; }

        [Display(Name = "Name of Medical Power of Attorney")]
        [StringLength(100, MinimumLength = 3)]
        public string MedPowerOfAttorneyName { get; set; }

        [Display(Name = "Date Signed")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [StringLength(60, MinimumLength = 5)]
        public DateTime DateMedPowerOfAttorney { get; set; }

        [Display(Name = "Last Updated:")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [StringLength(60, MinimumLength = 5)]
        public DateTime DateUpdatedMedPowerOfAttorney { get; set; }

        [Display(Name = "Copy On File")]
        [StringLength(3, MinimumLength = 1)]
        public string MedPowerOfAttorneyCopyOnFile { get; set; }

        [Display(Name = "Health care Proxy?")]
        [StringLength(3, MinimumLength = 1)]
        [Required]
        public string HealthCareProxy { get; set; }

        [Display(Name = "Health care proxy name")]
        [StringLength(60, MinimumLength = 1)]
        public string HealthCareProxyName { get; set; }

        [Display(Name = "Date Signed:")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [StringLength(60, MinimumLength = 5)]
        public DateTime HealthCareProxyDateSign { get; set; }

        [Display(Name = "Date Updated")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [StringLength(60, MinimumLength = 5)]
        public DateTime HealthCareProxyLastUpdate { get; set; }

        [Display(Name = "Do Not Resuscitate")]
        [StringLength(3, MinimumLength = 1)]
        [Required]
        public string DoNotResuscitate { get; set; }

        [Display(Name = "Date Signed")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [StringLength(60, MinimumLength = 5)]
        public DateTime DnrDateSign { get; set; }

        [Display(Name = "Date Updated")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [StringLength(60, MinimumLength = 5)]
        public DateTime DnrDateUpdate { get; set; }



        [Display(Name = "Organ Donor?")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [StringLength(3, MinimumLength = 1)]
        [Required]
        public string OrganDonorDocument { get; set; }

        [Display(Name = "Date Signed")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [StringLength(60, MinimumLength = 5)]
        public DateTime OrganDonorDocumentDateSign { get; set; }

        [Display(Name = "Date Updated")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [StringLength(60, MinimumLength = 5)]
        public DateTime OrganDonorDocumentLastUpdate { get; set; }

        [Display(Name = "Document Location")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string DocumentLocation { get; set; }

        [Display(Name = "Document Holder's First Name")]
        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string DocumentContactFirstName { get; set; }

        [Display(Name = "Document Holder's Last Name")]
        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string DocumentContactLastName { get; set; }

        [Display(Name = "Document Holder's Phone")]
        [StringLength(60, MinimumLength = 5)]
        [Required]
        public string DocumentContactPhone { get; set; }

        [Display(Name = "Attorney First Name")]
        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string AttorneyFirstName { get; set; }

        [Display(Name = "Attorney Last Name")]
        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string AttorneyLastName { get; set; }

        [Display(Name = "Attorney Phone")]
        [StringLength(60, MinimumLength = 5)]
        [Required]
        public string AttorneyPhone { get; set; }

        [Display(Name = "Comments")]
        [StringLength(500, MinimumLength = 1)]
        public string Comments { get; set; }
    }
}
