using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.test3
{
    public partial class WebFotograf
    {
        public Guid Oid { get; set; }
        public byte[] Fotograf { get; set; }
        public Guid? Urun { get; set; }
        public Guid? UrunSerisi { get; set; }
        public Guid? UrunGrubu { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public bool? Web { get; set; }
        public bool? EngWeb { get; set; }
        public int? Index { get; set; }
        public Guid? Aksesuar { get; set; }
        public Guid? AksesuarGrubu { get; set; }
        public Guid? KaliteliFotografOid { get; set; }
        public DateTime? SonGuncellemeTarihi { get; set; }

        public virtual AksesuarGrubu AksesuarGrubuNavigation { get; set; }
        public virtual Aksesuar AksesuarNavigation { get; set; }
        public virtual Fotograflar KaliteliFotografO { get; set; }
        public virtual UrunGrubu UrunGrubuNavigation { get; set; }
        public virtual Urunler UrunNavigation { get; set; }
        public virtual UrunSerisi UrunSerisiNavigation { get; set; }
    }
}
