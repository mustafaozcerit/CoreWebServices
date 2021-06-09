using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class UrunTeknikSartname
    {
        public Guid Oid { get; set; }
        public Guid? Urunler { get; set; }
        public Guid? TeknikSarnameler { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual TeknikSartname TeknikSarnamelerNavigation { get; set; }
        public virtual Urunler UrunlerNavigation { get; set; }
    }
}
