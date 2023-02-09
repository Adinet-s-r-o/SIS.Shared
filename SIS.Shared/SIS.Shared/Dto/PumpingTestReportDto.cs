using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.Dto
{
    public class PumpingTestReportDto
    {
        public int ObjectId { get; set; }
        public string Name { get; set; }
        public string AlternativeName { get; set; }
        public string IsPumpingTestString { get; set; }
        public string PumpingNote { get; set; }
        public string ActionImplementerHDZ { get; set; }
        public string ActionHydrogeologist { get; set; }
        public string ActionServisCompany { get; set; }
        public string ActionOperatingCompany { get; set; }
        public string ActionInvestment { get; set; }
        public string ValuationHPVStatic { get; set; }
        public string MeasuresToJustifyHPV { get; set; }
        public string AssessmentOfSpecificYield { get; set; }
        public string RationaleAssessmentSpecificYield { get; set; }
        public string RecommendationBasedOnHDZ { get; set; }
        public string ConclusionsOperatorOwner { get; set; }
        public DateTime? ValuationDate { get; set; }
    }
}
