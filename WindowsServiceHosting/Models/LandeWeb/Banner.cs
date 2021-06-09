using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class Banner
    {
        public Guid Oid { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public Guid? UrunSerisi { get; set; }
        public byte[] Fotograf { get; set; }
        public byte[] FotografEng { get; set; }
        public Guid? IkVizyonPolitika { get; set; }
        public Guid? GizlilikPolitikasi { get; set; }
        public Guid? CerezPolitikasi { get; set; }
        public Guid? AydinlatmaMetni { get; set; }
        public Guid? UrunGrup { get; set; }
        public bool? TumSeriler { get; set; }
        public DateTime? SonGuncellemeTarihi { get; set; }
        public Guid? AksesuarGrup { get; set; }

        public virtual AksesuarGrubu AksesuarGrupNavigation { get; set; }
        public virtual AydinlatmaMetni AydinlatmaMetniNavigation { get; set; }
        public virtual CerezPolitikasi CerezPolitikasiNavigation { get; set; }
        public virtual GizlilikPolitikasi GizlilikPolitikasiNavigation { get; set; }
        public virtual IkVizyonPolitika IkVizyonPolitikaNavigation { get; set; }
        public virtual UrunGrubu UrunGrupNavigation { get; set; }
        public virtual UrunSerisi UrunSerisiNavigation { get; set; }
    }
}
