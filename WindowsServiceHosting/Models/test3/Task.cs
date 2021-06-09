using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.test3
{
    public partial class Task
    {
        public Guid Oid { get; set; }
        public DateTime? DateCompleted { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? StartDate { get; set; }
        public Guid? AssignedTo { get; set; }
        public int? Status { get; set; }
        public int? PercentCompleted { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual Party AssignedToNavigation { get; set; }
    }
}
