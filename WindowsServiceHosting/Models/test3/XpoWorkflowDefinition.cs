using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.test3
{
    public partial class XpoWorkflowDefinition
    {
        public Guid Oid { get; set; }
        public string Name { get; set; }
        public string Xaml { get; set; }
        public string TargetObjectType { get; set; }
        public string Criteria { get; set; }
        public bool? IsActive { get; set; }
        public bool? AutoStartWhenObjectIsCreated { get; set; }
        public bool? AutoStartWhenObjectFitsCriteria { get; set; }
        public bool? AllowMultipleRuns { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
    }
}
