using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class Aksesuar
    {
        public Aksesuar()
        {
            AksesuarDeger = new HashSet<AksesuarDeger>();
            DigerDokumanlar = new HashSet<DigerDokumanlar>();
            FiyatListesi = new HashSet<FiyatListesi>();
            Fotograflar = new HashSet<Fotograflar>();
            KaliteDokumanlari = new HashSet<KaliteDokumanlari>();
            Kataloglar = new HashSet<Kataloglar>();
            MontajKlavuzlari = new HashSet<MontajKlavuzlari>();
            Sertifikalar = new HashSet<Sertifikalar>();
            Taglar = new HashSet<Taglar>();
            TeknikCizimler = new HashSet<TeknikCizimler>();
            TeknikSartname = new HashSet<TeknikSartname>();
            UretimDokumanlari = new HashSet<UretimDokumanlari>();
            UrunlerurunlerAksesuaraksesuar = new HashSet<UrunlerurunlerAksesuaraksesuar>();
            WebFotograf = new HashSet<WebFotograf>();
        }

        public Guid Oid { get; set; }
        public string AksesuarAdi { get; set; }
        public string AksesuarKodu { get; set; }
        public Guid? Yukseklik { get; set; }
        public Guid? Boyut { get; set; }
        public string OlusturanKisi { get; set; }
        public Guid? AksesuarGrubu { get; set; }
        public bool? Web { get; set; }
        public Guid? UrunGrubu { get; set; }
        public Guid? UrunSerisi { get; set; }
        public Guid? Urunler { get; set; }
        public Guid? UrunAilesi { get; set; }
        public DateTime? OlusturmaTarihi { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public string Aciklama { get; set; }
        public string EngAksesuarAdi { get; set; }
        public string EngAciklama { get; set; }
        public bool? EngWeb { get; set; }
        public string StokKodu { get; set; }
        public int? Index { get; set; }
        public DateTime? SonGuncellemeTarihi { get; set; }
        public string AksesuarAdi1 { get; set; }
        public string WebUrl { get; set; }
        public string EngWebUrl { get; set; }

        public virtual AksesuarGrubu AksesuarGrubuNavigation { get; set; }
        public virtual Boyut BoyutNavigation { get; set; }
        public virtual UrunAilesi UrunAilesiNavigation { get; set; }
        public virtual UrunGrubu UrunGrubuNavigation { get; set; }
        public virtual UrunSerisi UrunSerisiNavigation { get; set; }
        public virtual Urunler UrunlerNavigation { get; set; }
        public virtual Yukseklik YukseklikNavigation { get; set; }
        public virtual ICollection<AksesuarDeger> AksesuarDeger { get; set; }
        public virtual ICollection<DigerDokumanlar> DigerDokumanlar { get; set; }
        public virtual ICollection<FiyatListesi> FiyatListesi { get; set; }
        public virtual ICollection<Fotograflar> Fotograflar { get; set; }
        public virtual ICollection<KaliteDokumanlari> KaliteDokumanlari { get; set; }
        public virtual ICollection<Kataloglar> Kataloglar { get; set; }
        public virtual ICollection<MontajKlavuzlari> MontajKlavuzlari { get; set; }
        public virtual ICollection<Sertifikalar> Sertifikalar { get; set; }
        public virtual ICollection<Taglar> Taglar { get; set; }
        public virtual ICollection<TeknikCizimler> TeknikCizimler { get; set; }
        public virtual ICollection<TeknikSartname> TeknikSartname { get; set; }
        public virtual ICollection<UretimDokumanlari> UretimDokumanlari { get; set; }
        public virtual ICollection<UrunlerurunlerAksesuaraksesuar> UrunlerurunlerAksesuaraksesuar { get; set; }
        public virtual ICollection<WebFotograf> WebFotograf { get; set; }
    }
}
