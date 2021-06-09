using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class Iletisim
    {
        public Guid Oid { get; set; }
        public string IstTelefon { get; set; }
        public string IstFax { get; set; }
        public string IstAdres { get; set; }
        public string EskTelefon { get; set; }
        public string EskFax { get; set; }
        public string EskAdres { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public DateTime? SonGuncellemeTarihi { get; set; }
    }
}
