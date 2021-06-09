using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.test3
{
    public partial class KurumsalLogoKullanimi
    {
        public Guid Oid { get; set; }
        public Guid? File { get; set; }
        public string Adi { get; set; }
        public string Enadi { get; set; }
        public Guid? Katalog { get; set; }
        public Guid? Enkatalog { get; set; }
        public DateTime? SonGuncellemeTarihi { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual FileData EnkatalogNavigation { get; set; }
        public virtual FileData FileNavigation { get; set; }
        public virtual FileData KatalogNavigation { get; set; }
    }
}
