using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.test3
{
    public partial class OnayBekleyenDokumanlar
    {
        public Guid Oid { get; set; }
        public Guid? File { get; set; }
        public Guid? UserMid2 { get; set; }
        public bool? Red { get; set; }
        public string DokumanOlusturanKisi { get; set; }
        public DateTime? DokumanOlusturulmaTarihi { get; set; }
        public DateTime? DokumanOnaylanmaTarihi { get; set; }
        public Guid? FileOid { get; set; }
        public bool? Onay { get; set; }
        public string ObjectType { get; set; }
        public Guid? Yetkilendirme { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public string UrunAilesi { get; set; }
        public string UrunGrubu { get; set; }
        public string UrunSerisi { get; set; }
        public string Urunler { get; set; }
        public string OcrText { get; set; }

        public virtual FileData FileNavigation { get; set; }
        public virtual UserMid2 UserMid2Navigation { get; set; }
        public virtual Yetkilendirme YetkilendirmeNavigation { get; set; }
    }
}
