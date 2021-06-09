using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.test3
{
    public partial class HakkimizdaAltGrup
    {
        public Guid Oid { get; set; }
        public byte[] Fotograf { get; set; }
        public string GrupBaslik { get; set; }
        public string GrupAciklama { get; set; }
        public string EngGrupBaslik2 { get; set; }
        public string EngGrupAciklama { get; set; }
        public Guid? Hakkimizda { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public DateTime? SonGuncellemeTarihi { get; set; }

        public virtual HakkimizdaVeAltBilgi HakkimizdaNavigation { get; set; }
    }
}
