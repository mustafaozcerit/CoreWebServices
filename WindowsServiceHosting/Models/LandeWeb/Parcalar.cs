using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class Parcalar
    {
        public Parcalar()
        {
            DigerDokumanlar = new HashSet<DigerDokumanlar>();
            FiyatListesi = new HashSet<FiyatListesi>();
            Fotograflar = new HashSet<Fotograflar>();
            KaliteDokumanlari = new HashSet<KaliteDokumanlari>();
            MontajKlavuzlari = new HashSet<MontajKlavuzlari>();
            Sertifikalar = new HashSet<Sertifikalar>();
            Taglar = new HashSet<Taglar>();
            TeknikCizimler = new HashSet<TeknikCizimler>();
            UretimDokumanlari = new HashSet<UretimDokumanlari>();
        }

        public Guid Oid { get; set; }
        public string ParcaKodu { get; set; }
        public string ParcaAdi { get; set; }
        public string SeriKisaKodu { get; set; }
        public string OlusturanKisi { get; set; }
        public bool? Web { get; set; }
        public Guid? UrunAilesi { get; set; }
        public Guid? UrunGrubu { get; set; }
        public Guid? UrunSerisi { get; set; }
        public Guid? Urunler { get; set; }
        public DateTime? OlusturmaTarihi { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual UrunAilesi UrunAilesiNavigation { get; set; }
        public virtual UrunGrubu UrunGrubuNavigation { get; set; }
        public virtual UrunSerisi UrunSerisiNavigation { get; set; }
        public virtual Urunler UrunlerNavigation { get; set; }
        public virtual ICollection<DigerDokumanlar> DigerDokumanlar { get; set; }
        public virtual ICollection<FiyatListesi> FiyatListesi { get; set; }
        public virtual ICollection<Fotograflar> Fotograflar { get; set; }
        public virtual ICollection<KaliteDokumanlari> KaliteDokumanlari { get; set; }
        public virtual ICollection<MontajKlavuzlari> MontajKlavuzlari { get; set; }
        public virtual ICollection<Sertifikalar> Sertifikalar { get; set; }
        public virtual ICollection<Taglar> Taglar { get; set; }
        public virtual ICollection<TeknikCizimler> TeknikCizimler { get; set; }
        public virtual ICollection<UretimDokumanlari> UretimDokumanlari { get; set; }
    }
}
