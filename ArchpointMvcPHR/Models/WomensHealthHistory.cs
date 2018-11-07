using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [DataType(DataType.Date)]
        public DateTime DateLastClinicialBreastExam { get; set; }

        public string ResultsLastBreastExam { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateNextBreastExam { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateLastMammogram { get; set; }

        public string ResultsLastMammogram { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateNextMammogram { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateLastPapExam { get; set; }

        public string ResultsLastPapExam { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateNextPapExam { get; set; }

        public string WomensDiseaseDisorder { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfDiagnosis { get; set; }

        public string WomensDiseaseDisorderStatus { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateResolved { get; set; }

        public string WomensHealthSurgeryProcedure { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfSurgeryProcedure { get; set; }

        /*
        public int MedCareLocationId { get; set; }
        */

        public int AgePeriodsStarted { get; set; }

        public string PeriodsRegular { get; set; }

        public string PeriodProblems { get; set; }

        public string PeriodFlow { get; set; }

        public string StillHavingPeriods { get; set; }

        public string BirthControlMethod { get; set; }

        public string HormoneReplacementTherapy { get; set; }

        [DataType(DataType.Date)]
        public DateTime HrtDateStarted { get; set; }

        [DataType(DataType.Date)]
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
