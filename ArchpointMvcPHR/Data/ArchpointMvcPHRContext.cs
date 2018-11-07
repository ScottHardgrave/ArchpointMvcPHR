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

        public DbSet<ArchpointMvcPHR.Models.DoctorAppointment> DoctorAppointment { get; set; }

        public DbSet<ArchpointMvcPHR.Models.MedicalHistory> MedicalHistory { get; set; }

        public DbSet<ArchpointMvcPHR.Models.FamilyHistory> FamilyHistory { get; set; }

        public DbSet<ArchpointMvcPHR.Models.A1CTestRisk> A1CTestRisk { get; set; }

        public DbSet<ArchpointMvcPHR.Models.AlcoholRisk> AlcoholRisk { get; set; }

        public DbSet<ArchpointMvcPHR.Models.AllergyHistory> AllergyHistory { get; set; }

        public DbSet<ArchpointMvcPHR.Models.AsthmaRisk> AsthmaRisk { get; set; }

        public DbSet<ArchpointMvcPHR.Models.BloodPressureRisk> BloodPressureRisk { get; set; }

        public DbSet<ArchpointMvcPHR.Models.CholesterolRisk> CholesterolRisk { get; set; }

        public DbSet<ArchpointMvcPHR.Models.DiabetesRisk> DiabetesRisk { get; set; }

        public DbSet<ArchpointMvcPHR.Models.DrugUseRisk> DrugUseRisk { get; set; }

        public DbSet<ArchpointMvcPHR.Models.ExerciseActivityRisk> ExerciseActivityRisk { get; set; }

        public DbSet<ArchpointMvcPHR.Models.Feedback> Feedback { get; set; }

        public DbSet<ArchpointMvcPHR.Models.Immunizations> Immunizations { get; set; }

        public DbSet<ArchpointMvcPHR.Models.WomensHealthHistory> WomensHealthHistory { get; set; }

        public DbSet<ArchpointMvcPHR.Models.WeightAndMeasurementRisk> WeightAndMeasurementRisk { get; set; }

        public DbSet<ArchpointMvcPHR.Models.User> User { get; set; }

        public DbSet<ArchpointMvcPHR.Models.TravelHealth> TravelHealth { get; set; }

        public DbSet<ArchpointMvcPHR.Models.TestsExams> TestsExams { get; set; }

        public DbSet<ArchpointMvcPHR.Models.StdHistory> StdHistory { get; set; }

        public DbSet<ArchpointMvcPHR.Models.SurgicalHistory> SurgicalHistory { get; set; }

        public DbSet<ArchpointMvcPHR.Models.SmokingHistoryRisk> SmokingHistoryRisk { get; set; }

        public DbSet<ArchpointMvcPHR.Models.MedCareLocation> MedCareLocation { get; set; }

        public DbSet<ArchpointMvcPHR.Models.MensHealth> MensHealth { get; set; }

        public DbSet<ArchpointMvcPHR.Models.CancerHistory> CancerHistory { get; set; }

        public DbSet<ArchpointMvcPHR.Models.Caregivers> Caregivers { get; set; }

        public DbSet<ArchpointMvcPHR.Models.EarNoseThroatHistory> EarNoseThroatHistory { get; set; }

        public DbSet<ArchpointMvcPHR.Models.EyeHistory> EyeHistory { get; set; }

        public DbSet<ArchpointMvcPHR.Models.HeartHistory> HeartHistory { get; set; }

        public DbSet<ArchpointMvcPHR.Models.MentalHealthHistory> MentalHealthHistory { get; set; }
    }
}
