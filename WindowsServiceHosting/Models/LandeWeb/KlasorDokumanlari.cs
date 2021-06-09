using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class KlasorDokumanlari
    {
        public KlasorDokumanlari()
        {
            Revizeler = new HashSet<Revizeler>();
            Taglar = new HashSet<Taglar>();
        }

        public Guid Oid { get; set; }
        public Guid? File { get; set; }
        public string OlusturanKisi { get; set; }
        public Guid? Klasorler { get; set; }
        public string DokumanAdi { get; set; }
        public string DokumanUzanti { get; set; }
        public int? DokumanType { get; set; }
        public DateTime? OlusturmaTarihi { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public bool? Onay { get; set; }
        public bool? Red { get; set; }
        public string OcrText { get; set; }

        public virtual FileData FileNavigation { get; set; }
        public virtual Klasorler KlasorlerNavigation { get; set; }
        public virtual ICollection<Revizeler> Revizeler { get; set; }
        public virtual ICollection<Taglar> Taglar { get; set; }
    }
}
