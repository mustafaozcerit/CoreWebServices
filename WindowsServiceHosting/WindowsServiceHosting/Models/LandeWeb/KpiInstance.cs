using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class KpiInstance
    {
        public KpiInstance()
        {
            KpiDefinitionNavigation = new HashSet<KpiDefinition>();
            KpiHistoryItem = new HashSet<KpiHistoryItem>();
            KpiScorecardScorecardsKpiInstanceIndicators = new HashSet<KpiScorecardScorecardsKpiInstanceIndicators>();
        }

        public Guid Oid { get; set; }
        public DateTime? ForceMeasurementDateTime { get; set; }
        public Guid? KpiDefinition { get; set; }
        public string Settings { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual KpiDefinition KpiDefinition1 { get; set; }
        public virtual ICollection<KpiDefinition> KpiDefinitionNavigation { get; set; }
        public virtual ICollection<KpiHistoryItem> KpiHistoryItem { get; set; }
        public virtual ICollection<KpiScorecardScorecardsKpiInstanceIndicators> KpiScorecardScorecardsKpiInstanceIndicators { get; set; }
    }
}
