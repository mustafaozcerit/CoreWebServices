using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.test3
{
    public partial class Haberler
    {
        public Guid Oid { get; set; }
        public string HaberBaslik { get; set; }
        public string HaberAciklama { get; set; }
        public DateTime? HaberTarih { get; set; }
        public string HaberLink { get; set; }
        public DateTime? OlusturmaTarihi { get; set; }
        public string OlusturanKisi { get; set; }
        public byte[] HaberFoto { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public int? Web { get; set; }
        public int? Index { get; set; }
        public DateTime? SonGuncellemeTarihi { get; set; }
    }
}
