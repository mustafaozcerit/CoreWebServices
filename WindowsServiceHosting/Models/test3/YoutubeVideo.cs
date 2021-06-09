using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.test3
{
    public partial class YoutubeVideo
    {
        public Guid Oid { get; set; }
        public string Link { get; set; }
        public string Aciklama { get; set; }
        public DateTime? OlusturmaTarihi { get; set; }
        public string OlusturanKisi { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public string ResimLinki { get; set; }
        public string Value { get; set; }
        public bool? AnasayfadaGoster { get; set; }
        public string EngAciklama { get; set; }
        public Guid? VideolarSayfasi { get; set; }
        public int? Index { get; set; }
        public DateTime? SonGuncellemeTarihi { get; set; }

        public virtual VideolarSayfasi VideolarSayfasiNavigation { get; set; }
    }
}
