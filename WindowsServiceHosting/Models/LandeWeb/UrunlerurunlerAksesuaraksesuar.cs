using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class UrunlerurunlerAksesuaraksesuar
    {
        public Guid? Aksesuar { get; set; }
        public Guid? Urunler { get; set; }
        public Guid Oid { get; set; }
        public int? OptimisticLockField { get; set; }
        public DateTime? SonGuncellemeTarihi { get; set; }

        public virtual Aksesuar AksesuarNavigation { get; set; }
        public virtual Urunler UrunlerNavigation { get; set; }
    }
}
