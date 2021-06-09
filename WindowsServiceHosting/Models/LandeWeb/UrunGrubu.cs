using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class UrunGrubu
    {
        public UrunGrubu()
        {
            Aksesuar = new HashSet<Aksesuar>();
            Banner = new HashSet<Banner>();
            DigerDokumanlar = new HashSet<DigerDokumanlar>();
            Fotograflar = new HashSet<Fotograflar>();
            KaliteDokumanlari = new HashSet<KaliteDokumanlari>();
            KapakOpsiyonlari = new HashSet<KapakOpsiyonlari>();
            Kataloglar = new HashSet<Kataloglar>();
            MontajKlavuzlari = new HashSet<MontajKlavuzlari>();
            Parcalar = new HashSet<Parcalar>();
            Sertifikalar = new HashSet<Sertifikalar>();
            Taglar = new HashSet<Taglar>();
            TeknikCizimler = new HashSet<TeknikCizimler>();
            TeknikSartname = new HashSet<TeknikSartname>();
            UretimDokumanlari = new HashSet<UretimDokumanlari>();
            UrunSerisi = new HashSet<UrunSerisi>();
            Urunler = new HashSet<Urunler>();
            WebFotograf = new HashSet<WebFotograf>();
        }

        public Guid Oid { get; set; }
        public string UrunGrubuAdi { get; set; }
        public Guid? UrunAilesi { get; set; }
        public string OlusturanKisi { get; set; }
        public string Aciklama { get; set; }
        public bool? Web { get; set; }
        public DateTime? OlusturmaTarihi { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public string EngUrunGrubuAdi { get; set; }
        public string EngAciklama { get; set; }
        public bool? EngWeb { get; set; }
        public int? Index { get; set; }
        public DateTime? SonGuncellemeTarihi { get; set; }
        public string WebUrl { get; set; }
        public string EngWebUrl { get; set; }

        public virtual UrunAilesi UrunAilesiNavigation { get; set; }
        public virtual ICollection<Aksesuar> Aksesuar { get; set; }
        public virtual ICollection<Banner> Banner { get; set; }
        public virtual ICollection<DigerDokumanlar> DigerDokumanlar { get; set; }
        public virtual ICollection<Fotograflar> Fotograflar { get; set; }
        public virtual ICollection<KaliteDokumanlari> KaliteDokumanlari { get; set; }
        public virtual ICollection<KapakOpsiyonlari> KapakOpsiyonlari { get; set; }
        public virtual ICollection<Kataloglar> Kataloglar { get; set; }
        public virtual ICollection<MontajKlavuzlari> MontajKlavuzlari { get; set; }
        public virtual ICollection<Parcalar> Parcalar { get; set; }
        public virtual ICollection<Sertifikalar> Sertifikalar { get; set; }
        public virtual ICollection<Taglar> Taglar { get; set; }
        public virtual ICollection<TeknikCizimler> TeknikCizimler { get; set; }
        public virtual ICollection<TeknikSartname> TeknikSartname { get; set; }
        public virtual ICollection<UretimDokumanlari> UretimDokumanlari { get; set; }
        public virtual ICollection<UrunSerisi> UrunSerisi { get; set; }
        public virtual ICollection<Urunler> Urunler { get; set; }
        public virtual ICollection<WebFotograf> WebFotograf { get; set; }
    }
}
