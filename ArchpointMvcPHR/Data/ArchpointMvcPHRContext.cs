﻿using System;
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

        public DbSet<ArchpointMvcPHR.Models.FamilyHistory> FamilyHistory { get; set; }
    }
}
