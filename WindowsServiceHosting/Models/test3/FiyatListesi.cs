using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.test3
{
    public partial class FiyatListesi
    {
        public Guid Oid { get; set; }
        public Guid? File { get; set; }
        public double? ListeFiyati { get; set; }
        public Guid? Currency { get; set; }
        public Guid? Aksesuar { get; set; }
        public Guid? Parcalar { get; set; }
        public string OlusturanKisi { get; set; }
        public bool? Web { get; set; }
        public Guid? Urunler { get; set; }
        public string DokumanAdi { get; set; }
        public string DokumanUzanti { get; set; }
        public int? DokumanType { get; set; }
        public DateTime? OlusturmaTarihi { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public Guid? FileData { get; set; }

        public virtual Aksesuar AksesuarNavigation { get; set; }
        public virtual Currency CurrencyNavigation { get; set; }
        public virtual FileData FileDataNavigation { get; set; }
        public virtual FileData FileNavigation { get; set; }
        public virtual Parcalar ParcalarNavigation { get; set; }
        public virtual Urunler UrunlerNavigation { get; set; }
    }
}
