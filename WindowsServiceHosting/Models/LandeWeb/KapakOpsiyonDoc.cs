using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class KapakOpsiyonDoc
    {
        public Guid Oid { get; set; }
        public Guid? File { get; set; }
        public Guid? KapakOpsiyonlari { get; set; }
        public bool? Web { get; set; }
        public DateTime? OlusturmaTarihi { get; set; }
        public string OlusturanKisi { get; set; }
        public string DokumanAdi { get; set; }
        public string DokumanUzanti { get; set; }
        public int? DokumanType { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public string OcrText { get; set; }
        public DateTime? SonGuncellemeTarihi { get; set; }

        public virtual FileData FileNavigation { get; set; }
        public virtual KapakOpsiyonlari KapakOpsiyonlariNavigation { get; set; }
    }
}
