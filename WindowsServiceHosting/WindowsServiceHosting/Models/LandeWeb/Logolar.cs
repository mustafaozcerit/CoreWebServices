using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class Logolar
    {
        public Guid Oid { get; set; }
        public DateTime? OlusturmaTarihi { get; set; }
        public string OlusturanKisi { get; set; }
        public bool? Web { get; set; }
        public Guid? KaliteDokumanlari { get; set; }
        public byte[] LogoResmi { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual KaliteDokumanlari KaliteDokumanlariNavigation { get; set; }
    }
}
