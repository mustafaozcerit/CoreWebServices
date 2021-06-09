using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.test3
{
    public partial class Reklamlar
    {
        public Guid Oid { get; set; }
        public DateTime? OlusturmaTarihi { get; set; }
        public string OlusturanKisi { get; set; }
        public byte[] Image { get; set; }
        public string Baslik { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public int? Web { get; set; }
        public bool? Aktif { get; set; }
        public DateTime? SonGuncellemeTarihi { get; set; }
    }
}
