using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class Revizeler
    {
        public Guid Oid { get; set; }
        public Guid? TeknikCizimler { get; set; }
        public Guid? UretimDokumanlari { get; set; }
        public Guid? Fotograflar { get; set; }
        public Guid? KaliteDokumanlari { get; set; }
        public Guid? KlasorDokumanlari { get; set; }
        public string RevizeEdenKisi { get; set; }
        public string RevizeNedeni { get; set; }
        public Guid? RevizeDokuman { get; set; }
        public Guid? YeniDokuman { get; set; }
        public Guid? DigerDokumanlar { get; set; }
        public bool? Web { get; set; }
        public Guid? MontajKlavuzlari { get; set; }
        public DateTime? RevizeTarihi { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public Guid? RevizeNedenleri { get; set; }
        public Guid? SertifikaDoc { get; set; }
        public Guid? SertifikaDokumanlari { get; set; }
        public bool? MakineyeIslendi { get; set; }
        public Guid? TeknikSartname { get; set; }

        public virtual DigerDokumanlar DigerDokumanlarNavigation { get; set; }
        public virtual Fotograflar FotograflarNavigation { get; set; }
        public virtual KaliteDokumanlari KaliteDokumanlariNavigation { get; set; }
        public virtual KlasorDokumanlari KlasorDokumanlariNavigation { get; set; }
        public virtual MontajKlavuzlari MontajKlavuzlariNavigation { get; set; }
        public virtual FileData RevizeDokumanNavigation { get; set; }
        public virtual RevizeNedenleri RevizeNedenleriNavigation { get; set; }
        public virtual Sertifikalar SertifikaDokumanlariNavigation { get; set; }
        public virtual TeknikCizimler TeknikCizimlerNavigation { get; set; }
        public virtual TeknikSartname TeknikSartnameNavigation { get; set; }
        public virtual UretimDokumanlari UretimDokumanlariNavigation { get; set; }
        public virtual FileData YeniDokumanNavigation { get; set; }
    }
}
