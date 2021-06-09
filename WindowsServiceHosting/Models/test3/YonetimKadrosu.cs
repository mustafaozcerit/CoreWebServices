using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.test3
{
    public partial class YonetimKadrosu
    {
        public Guid Oid { get; set; }
        public byte[] Fotograf { get; set; }
        public string Adi { get; set; }
        public string Görevi { get; set; }
        public string GöreviEng { get; set; }
        public int? Index { get; set; }
        public Guid? Hakkimizda { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public DateTime? SonGuncellemeTarihi { get; set; }

        public virtual HakkimizdaVeAltBilgi HakkimizdaNavigation { get; set; }
    }
}
