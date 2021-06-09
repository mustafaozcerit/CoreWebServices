using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class DigerDokumanlar
    {
        public DigerDokumanlar()
        {
            Revizeler = new HashSet<Revizeler>();
            Taglar = new HashSet<Taglar>();
        }

        public Guid Oid { get; set; }
        public Guid? File { get; set; }
        public Guid? Aksesuar { get; set; }
        public Guid? Parcalar { get; set; }
        public string OlusturanKisi { get; set; }
        public bool? Web { get; set; }
        public Guid? UrunAilesi { get; set; }
        public Guid? UrunGrubu { get; set; }
        public Guid? UrunSerisi { get; set; }
        public Guid? Urunler { get; set; }
        public string DokumanAdi { get; set; }
        public string DokumanUzanti { get; set; }
        public int? DokumanType { get; set; }
        public DateTime? OlusturmaTarihi { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public bool? Onay { get; set; }
        public bool? Red { get; set; }
        public string OcrText { get; set; }
        public byte[] Fotograf { get; set; }
        public string WebDokumanAdi { get; set; }
        public bool? EngWeb { get; set; }
        public string EngWebDokumanAdi { get; set; }
        public bool? DigerDokumanlarSayfasi { get; set; }
        public DateTime? SonGuncellemeTarihi { get; set; }

        public virtual Aksesuar AksesuarNavigation { get; set; }
        public virtual FileData FileNavigation { get; set; }
        public virtual Parcalar ParcalarNavigation { get; set; }
        public virtual UrunAilesi UrunAilesiNavigation { get; set; }
        public virtual UrunGrubu UrunGrubuNavigation { get; set; }
        public virtual UrunSerisi UrunSerisiNavigation { get; set; }
        public virtual Urunler UrunlerNavigation { get; set; }
        public virtual ICollection<Revizeler> Revizeler { get; set; }
        public virtual ICollection<Taglar> Taglar { get; set; }
    }
}
