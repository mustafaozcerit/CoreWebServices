using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class FileData
    {
        public FileData()
        {
            DigerDokumanlar = new HashSet<DigerDokumanlar>();
            FiyatListesiFileDataNavigation = new HashSet<FiyatListesi>();
            FiyatListesiFileNavigation = new HashSet<FiyatListesi>();
            Fotograflar = new HashSet<Fotograflar>();
            KaliteDokumanlari = new HashSet<KaliteDokumanlari>();
            KapakOpsiyonDoc = new HashSet<KapakOpsiyonDoc>();
            Kataloglar = new HashSet<Kataloglar>();
            KlasorDokumanlari = new HashSet<KlasorDokumanlari>();
            KurumsalLogoKullanimiEnkatalogNavigation = new HashSet<KurumsalLogoKullanimi>();
            KurumsalLogoKullanimiFileNavigation = new HashSet<KurumsalLogoKullanimi>();
            KurumsalLogoKullanimiKatalogNavigation = new HashSet<KurumsalLogoKullanimi>();
            MontajKlavuzlari = new HashSet<MontajKlavuzlari>();
            OnayBekleyenDokumanlar = new HashSet<OnayBekleyenDokumanlar>();
            RevizelerRevizeDokumanNavigation = new HashSet<Revizeler>();
            RevizelerYeniDokumanNavigation = new HashSet<Revizeler>();
            Sertifikalar = new HashSet<Sertifikalar>();
            TeknikCizimler = new HashSet<TeknikCizimler>();
            TeknikSartname = new HashSet<TeknikSartname>();
            UretimDokumanlari = new HashSet<UretimDokumanlari>();
        }

        public Guid Oid { get; set; }
        public int? Size { get; set; }
        public string FileName { get; set; }
        public byte[] Content { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public DateTime? SonGuncellemeTarihi { get; set; }

        public virtual ICollection<DigerDokumanlar> DigerDokumanlar { get; set; }
        public virtual ICollection<FiyatListesi> FiyatListesiFileDataNavigation { get; set; }
        public virtual ICollection<FiyatListesi> FiyatListesiFileNavigation { get; set; }
        public virtual ICollection<Fotograflar> Fotograflar { get; set; }
        public virtual ICollection<KaliteDokumanlari> KaliteDokumanlari { get; set; }
        public virtual ICollection<KapakOpsiyonDoc> KapakOpsiyonDoc { get; set; }
        public virtual ICollection<Kataloglar> Kataloglar { get; set; }
        public virtual ICollection<KlasorDokumanlari> KlasorDokumanlari { get; set; }
        public virtual ICollection<KurumsalLogoKullanimi> KurumsalLogoKullanimiEnkatalogNavigation { get; set; }
        public virtual ICollection<KurumsalLogoKullanimi> KurumsalLogoKullanimiFileNavigation { get; set; }
        public virtual ICollection<KurumsalLogoKullanimi> KurumsalLogoKullanimiKatalogNavigation { get; set; }
        public virtual ICollection<MontajKlavuzlari> MontajKlavuzlari { get; set; }
        public virtual ICollection<OnayBekleyenDokumanlar> OnayBekleyenDokumanlar { get; set; }
        public virtual ICollection<Revizeler> RevizelerRevizeDokumanNavigation { get; set; }
        public virtual ICollection<Revizeler> RevizelerYeniDokumanNavigation { get; set; }
        public virtual ICollection<Sertifikalar> Sertifikalar { get; set; }
        public virtual ICollection<TeknikCizimler> TeknikCizimler { get; set; }
        public virtual ICollection<TeknikSartname> TeknikSartname { get; set; }
        public virtual ICollection<UretimDokumanlari> UretimDokumanlari { get; set; }
    }
}
