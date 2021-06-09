using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.test3
{
    public partial class Urunler
    {
        public Urunler()
        {
            Aksesuar = new HashSet<Aksesuar>();
            Degerler = new HashSet<Degerler>();
            DigerDokumanlar = new HashSet<DigerDokumanlar>();
            FiyatListesi = new HashSet<FiyatListesi>();
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
            UrunDegerler = new HashSet<UrunDegerler>();
            UrunTeknikSartname = new HashSet<UrunTeknikSartname>();
            UrunlerurunlerAksesuaraksesuar = new HashSet<UrunlerurunlerAksesuaraksesuar>();
            WebFotograf = new HashSet<WebFotograf>();
        }

        public Guid Oid { get; set; }
        public Guid? UrunAilesi { get; set; }
        public Guid? Boyut { get; set; }
        public Guid? Yukseklik { get; set; }
        public Guid? Renk { get; set; }
        public string StokKodu { get; set; }
        public string StokAdi { get; set; }
        public string KatalogKodu { get; set; }
        public string IngStokAdi { get; set; }
        public string Birim { get; set; }
        public int? Uretim { get; set; }
        public int? Satis { get; set; }
        public int? SatinAlma { get; set; }
        public string AnaUrunGrubu { get; set; }
        public string AltUrunTipi { get; set; }
        public int? SatisAnalizGrubu { get; set; }
        public string AltUrunGrubu { get; set; }
        public string UrunCinsi { get; set; }
        public string UrunTuru { get; set; }
        public string Barkod { get; set; }
        public string OlusturanKisi { get; set; }
        public string Aciklama { get; set; }
        public bool? Web { get; set; }
        public Guid? UrunSerisi { get; set; }
        public Guid? UrunGrubu { get; set; }
        public DateTime? OlusturmaTarihi { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public string EngAciklama { get; set; }
        public bool? EngWeb { get; set; }
        public bool? IlkFoto { get; set; }
        public int? Index { get; set; }
        public DateTime? SonGuncellemeTarihi { get; set; }
        public string WebUrl { get; set; }
        public string EngWebUrl { get; set; }

        public virtual Boyut BoyutNavigation { get; set; }
        public virtual Renk RenkNavigation { get; set; }
        public virtual UrunAilesi UrunAilesiNavigation { get; set; }
        public virtual UrunGrubu UrunGrubuNavigation { get; set; }
        public virtual UrunSerisi UrunSerisiNavigation { get; set; }
        public virtual Yukseklik YukseklikNavigation { get; set; }
        public virtual ICollection<Aksesuar> Aksesuar { get; set; }
        public virtual ICollection<Degerler> Degerler { get; set; }
        public virtual ICollection<DigerDokumanlar> DigerDokumanlar { get; set; }
        public virtual ICollection<FiyatListesi> FiyatListesi { get; set; }
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
        public virtual ICollection<UrunDegerler> UrunDegerler { get; set; }
        public virtual ICollection<UrunTeknikSartname> UrunTeknikSartname { get; set; }
        public virtual ICollection<UrunlerurunlerAksesuaraksesuar> UrunlerurunlerAksesuaraksesuar { get; set; }
        public virtual ICollection<WebFotograf> WebFotograf { get; set; }
    }
}
