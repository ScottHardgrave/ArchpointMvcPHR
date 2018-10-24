using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ArchpointMvcPHR.Models;

namespace ArchpointMvcPHR.Models
{
    public class ArchpointMvcPHRContext : DbContext
    {
        public ArchpointMvcPHRContext (DbContextOptions<ArchpointMvcPHRContext> options)
            : base(options)
        {
        }

        public DbSet<ArchpointMvcPHR.Models.Medication> Medication { get; set; }

        public DbSet<ArchpointMvcPHR.Models.LegalDocument> LegalDocument { get; set; }

        public DbSet<ArchpointMvcPHR.Models.PersonalInfo> PersonalInfo { get; set; }

        public DbSet<ArchpointMvcPHR.Models.Insurance> Insurance { get; set; }

        public DbSet<ArchpointMvcPHR.Models.Employment> Employment { get; set; }

        public DbSet<ArchpointMvcPHR.Models.EmergencyContact> EmergencyContact { get; set; }

        public DbSet<ArchpointMvcPHR.Models.MedicalProvider> MedicalProvider { get; set; }
    }
}
