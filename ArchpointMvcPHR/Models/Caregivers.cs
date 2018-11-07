using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArchpointMvcPHR.Models
{
    public class Caregivers
    {
        public int CaregiversId { get; set; }

        public string PatientFirstName { get; set; }

        public string PatientMiddleInitial { get; set; }

        public string patientLastName { get; set; }

        public string RelationshipToPatient { get; set; }

        public string StreetAddress { get; set; }

        public string City { get; set; }

        public string StateProvince { get; set; }

        public string ZipCode { get; set; }

        public string Country { get; set; }

        public string PhoneNumber { get; set; }

        public string EveningPhone { get; set; }

        public string CellPhone { get; set; }

        public string PatientCurrentlyInNursingFacility { get; set; }

    }
}
