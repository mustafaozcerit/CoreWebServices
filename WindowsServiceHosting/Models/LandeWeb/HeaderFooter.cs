using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class HeaderFooter
    {
        public Guid Oid { get; set; }
        public string AltBilgi { get; set; }
        public string EngAltBilgi { get; set; }
        public byte[] Fotograf { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public DateTime? SonGuncellemeTarihi { get; set; }
    }
}
