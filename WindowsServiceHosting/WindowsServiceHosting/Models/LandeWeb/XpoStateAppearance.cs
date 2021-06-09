using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class XpoStateAppearance
    {
        public Guid Oid { get; set; }
        public Guid? State { get; set; }
        public string AppearanceItemType { get; set; }
        public string Context { get; set; }
        public string Criteria { get; set; }
        public string Method { get; set; }
        public string TargetItems { get; set; }
        public int? Priority { get; set; }
        public int? FontColor { get; set; }
        public int? BackColor { get; set; }
        public int? FontStyle { get; set; }
        public bool? Enabled { get; set; }
        public int? Visibility { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual XpoState StateNavigation { get; set; }
    }
}
