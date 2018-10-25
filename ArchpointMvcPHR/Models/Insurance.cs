using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArchpointMvcPHR.Models
{
    public class Insurance
    {
        public int Id { get; set; }

        [Display(Name = "Primary Or Secondary")]
        [StringLength(20, MinimumLength = 4)]
        [Required]
        public string PrimaryOrSecondary { get; set; }

        [Display(Name = "Insurance Name")]
        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string InsuranceName { get; set; }

        [Display(Name = "Phone No")]
        [StringLength(20, MinimumLength = 4)]
        [Required]
        public string InsurancePhoneNum { get; set; }

        [Display(Name = "Street Address")]
        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string InsuranceStreetAddress { get; set; }

        [Display(Name = "City")]
        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string InsuranceCity { get; set; }

        [Display(Name = "State")]
        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string InsuranceState { get; set; }

        [Display(Name = "Country")]
        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string InsuranceCountry { get; set; }

        [Display(Name = "Policy I.D. No")]
        [StringLength(20, MinimumLength = 1)]
        [Required]
        public string PolicyIdNo { get; set; }

        [Display(Name = "Group No")]
        [StringLength(20, MinimumLength = 1)]
        [Required]
        public string GroupNo { get; set; }

        [Display(Name = "Plan Effective Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [StringLength(20, MinimumLength = 5)]
        [Required]
        public DateTime PlanEffectiveDate { get; set; }

        [Display(Name = "Authorization Phone No")]
        [StringLength(20, MinimumLength = 1)]
        [Required]
        public string AuthorizationPhoneNum { get; set; }

        [Display(Name = "Medicare Claim No")]
        public string MedicareClaimNum { get; set; }

        [Display(Name = "Medicaid Claim No")]
        public string MedicaidClaimNum { get; set; }

        [Display(Name = "Medicare/Medicaid Effective Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [StringLength(20, MinimumLength = 5)]
        public DateTime MedicareMedicaidEffectiveDate { get; set; }

        [Display(Name = "Policy Holder First Name")]
        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string PolicyHolderFirstName { get; set; }

        [Display(Name = "Policy Holder M.I.")]
        [StringLength(1)]
        [Required]
        public string PolicyHolderMidInit { get; set; }

        [Display(Name = "Policy Holder Last Name")]
        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string PolicyHolderLastName { get; set; }

        [Display(Name = "Relationship To Policy Holder")]
        [StringLength(20, MinimumLength = 1)]
        [Required]
        public string RelationshipToPolicyHolder { get; set; }

        [Display(Name = "Date of Birth")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [StringLength(20, MinimumLength = 5)]
        [Required]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "SSN")]
        [StringLength(11, MinimumLength = 9)]
        [Required]
        public string SocialSecurityNo { get; set; }


    }
}
