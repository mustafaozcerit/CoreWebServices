using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.test3
{
    public partial class Klasorler
    {
        public Klasorler()
        {
            InverseParentKlasorNavigation = new HashSet<Klasorler>();
            KlasorDokumanlari = new HashSet<KlasorDokumanlari>();
        }

        public Guid Oid { get; set; }
        public string KlasorAdi { get; set; }
        public string KlasorKodu { get; set; }
        public string OlusturanKisi { get; set; }
        public int? KlasorTipiEnum { get; set; }
        public Guid? ParentKlasor { get; set; }
        public DateTime? OlusturmaTarihi { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public string ParentKlasorName { get; set; }

        public virtual Klasorler ParentKlasorNavigation { get; set; }
        public virtual ICollection<Klasorler> InverseParentKlasorNavigation { get; set; }
        public virtual ICollection<KlasorDokumanlari> KlasorDokumanlari { get; set; }
    }
}
