using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class AksesuarDeger
    {
        public Guid Oid { get; set; }
        public DateTime? OlusturmaTarihi { get; set; }
        public string OlusturanKisi { get; set; }
        public string Deger { get; set; }
        public string EngDeger { get; set; }
        public Guid? Aksesuar { get; set; }
        public Guid? Degerler { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public DateTime? SonGuncellemeTarihi { get; set; }

        public virtual Aksesuar AksesuarNavigation { get; set; }
        public virtual Degerler DegerlerNavigation { get; set; }
    }
}
