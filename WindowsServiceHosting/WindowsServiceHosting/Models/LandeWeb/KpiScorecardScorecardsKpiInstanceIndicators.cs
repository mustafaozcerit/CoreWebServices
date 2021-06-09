using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class KpiScorecardScorecardsKpiInstanceIndicators
    {
        public Guid? Indicators { get; set; }
        public Guid? Scorecards { get; set; }
        public Guid Oid { get; set; }
        public int? OptimisticLockField { get; set; }

        public virtual KpiInstance IndicatorsNavigation { get; set; }
        public virtual KpiScorecard ScorecardsNavigation { get; set; }
    }
}
