using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class EmailListesi
    {
        public Guid Oid { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public string Email { get; set; }
        public bool? Aktif { get; set; }
        public bool? Pasif { get; set; }
    }
}
