using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.test3
{
    public partial class AksesuarGrubu
    {
        public AksesuarGrubu()
        {
            Aksesuar = new HashSet<Aksesuar>();
            Banner = new HashSet<Banner>();
            KaliteDokumanlari = new HashSet<KaliteDokumanlari>();
            Kataloglar = new HashSet<Kataloglar>();
            MontajKlavuzlari = new HashSet<MontajKlavuzlari>();
            Sertifikalar = new HashSet<Sertifikalar>();
            TeknikCizimler = new HashSet<TeknikCizimler>();
            WebFotograf = new HashSet<WebFotograf>();
        }

        public Guid Oid { get; set; }
        public string AksesuarGrupAdi { get; set; }
        public bool? Web { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public string Aciklama { get; set; }
        public byte[] Fotograf { get; set; }
        public string EngAksesuarGrupAdi { get; set; }
        public string EngAciklama { get; set; }
        public bool? EngWeb { get; set; }
        public int? Index { get; set; }
        public DateTime? SonGuncellemeTarihi { get; set; }
        public string WebUrl { get; set; }
        public string EngWebUrl { get; set; }
        public bool? KayitKontrol { get; set; }

        public virtual ICollection<Aksesuar> Aksesuar { get; set; }
        public virtual ICollection<Banner> Banner { get; set; }
        public virtual ICollection<KaliteDokumanlari> KaliteDokumanlari { get; set; }
        public virtual ICollection<Kataloglar> Kataloglar { get; set; }
        public virtual ICollection<MontajKlavuzlari> MontajKlavuzlari { get; set; }
        public virtual ICollection<Sertifikalar> Sertifikalar { get; set; }
        public virtual ICollection<TeknikCizimler> TeknikCizimler { get; set; }
        public virtual ICollection<WebFotograf> WebFotograf { get; set; }
    }
}
