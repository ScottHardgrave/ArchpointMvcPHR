using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArchpointMvcPHR.Models
{
    public class WomensHealthHistory
    {

        /*NEED TO FINISH
         * 
         * 
         * 
         * STILL NEED TO FINISH!!!!!!!!!
         * */
        public int WomensHealthHistoryId { get; set; }

        public int MedCareProviderId { get; set; }
        public DateTime DateLastClinicialBreastExam { get; set; }
        public string ResultsLastBreastExam { get; set; }
        public DateTime DateNextBreastExam { get; set; }
        public DateTime DateLastMammogram { get; set; }
        public string ResultsLastMammogram { get; set; }
        public DateTime DateNextMammogram { get; set; }
        public DateTime DateLastPapExam { get; set; }
        public string ResultsLastPapExam { get; set; }
        public DateTime DateNextPapExam { get; set; }
        public string WomensDiseaseDisorder { get; set; }
        public DateTime DateOfDiagnosis { get; set; }
        public string WomensDiseaseDisorderStatus { get; set; }
        public DateTime DateResolved { get; set; }
        public string WomensHealthSurgeryProcedure { get; set; }
        public DateTime DateOfSurgeryProcedure { get; set; }
        public int MedCareLocationId { get; set; }
        public int AgePeriodsStarted { get; set; }
        public string PeriodsRegular { get; set; }
        public string PeriodProblems { get; set; }
        public string PeriodFlow { get; set; }
        public string StillHavingPeriods { get; set; }
        public string BirthControlMethod { get; set; }
        public string HormoneReplacementTherapy { get; set; }
        public DateTime HrtDateStarted { get; set; }
        public DateTime HrtDateStopped { get; set; }
        public string NumOfPregnancies { get; set; }
        public string NumOfLiveBirths { get; set; }
        public string NumOfPrematureBirths { get; set; }
        public string NumOfStillBirths { get; set; }
        public string NumOfMiscarriages { get; set; }
        public string NumOfCsections { get; set; }
        public string NumOfElectiveAbortions { get; set; }
        public string PregnancyComplications { get; set; }

    }
}
