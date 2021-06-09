using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.test3
{
    public partial class Taglar
    {
        public Guid Oid { get; set; }
        public Guid? UrunAilesi { get; set; }
        public Guid? Urunler { get; set; }
        public Guid? Aksesuar { get; set; }
        public Guid? Parcalar { get; set; }
        public Guid? TeknikCizimler { get; set; }
        public Guid? UretimDokumanlari { get; set; }
        public Guid? Fotograflar { get; set; }
        public Guid? KaliteDokumanlari { get; set; }
        public string Tag { get; set; }
        public DateTime? OlusturmaTarihi { get; set; }
        public string OlusturanKisi { get; set; }
        public Guid? DigerDokumanlar { get; set; }
        public Guid? KapakOpsiyonlari { get; set; }
        public Guid? MontajKlavuzlari { get; set; }
        public Guid? KlasorDokumanlari { get; set; }
        public Guid? UrunGrubu { get; set; }
        public Guid? UrunSerisi { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public Guid? SertifikaDoc { get; set; }
        public Guid? SertifikaDokumanlari { get; set; }
        public Guid? TeknikSartname { get; set; }

        public virtual Aksesuar AksesuarNavigation { get; set; }
        public virtual DigerDokumanlar DigerDokumanlarNavigation { get; set; }
        public virtual Fotograflar FotograflarNavigation { get; set; }
        public virtual KaliteDokumanlari KaliteDokumanlariNavigation { get; set; }
        public virtual KapakOpsiyonlari KapakOpsiyonlariNavigation { get; set; }
        public virtual KlasorDokumanlari KlasorDokumanlariNavigation { get; set; }
        public virtual MontajKlavuzlari MontajKlavuzlariNavigation { get; set; }
        public virtual Parcalar ParcalarNavigation { get; set; }
        public virtual Sertifikalar SertifikaDokumanlariNavigation { get; set; }
        public virtual TeknikCizimler TeknikCizimlerNavigation { get; set; }
        public virtual TeknikSartname TeknikSartnameNavigation { get; set; }
        public virtual UretimDokumanlari UretimDokumanlariNavigation { get; set; }
        public virtual UrunAilesi UrunAilesiNavigation { get; set; }
        public virtual UrunGrubu UrunGrubuNavigation { get; set; }
        public virtual UrunSerisi UrunSerisiNavigation { get; set; }
        public virtual Urunler UrunlerNavigation { get; set; }
    }
}
