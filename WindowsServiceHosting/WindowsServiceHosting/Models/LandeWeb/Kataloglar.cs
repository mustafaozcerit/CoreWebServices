using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class Kataloglar
    {
        public Guid Oid { get; set; }
        public Guid? File { get; set; }
        public string KatalogAdi { get; set; }
        public Guid? UrunAilesi { get; set; }
        public Guid? UrunGrubu { get; set; }
        public Guid? UrunSerisi { get; set; }
        public Guid? Urunler { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public byte[] Fotograf { get; set; }
        public string WebDokumanAdi { get; set; }
        public bool? Web { get; set; }
        public bool? EngWeb { get; set; }
        public string EngWebDokumanAdi { get; set; }
        public bool? LandeGenelKatalog { get; set; }
        public bool? EngLandeGenelKatalog { get; set; }
        public bool? KataloglarSayfasi { get; set; }
        public int? Index { get; set; }
        public Guid? KataloglarSayfa { get; set; }
        public bool? Lklk { get; set; }
        public bool? EngLklk { get; set; }
        public Guid? Aksesuar { get; set; }
        public Guid? AksesuarGrubu { get; set; }
        public DateTime? SonGuncellemeTarihi { get; set; }
        public string WebUrl { get; set; }
        public string EngWebUrl { get; set; }

        public virtual AksesuarGrubu AksesuarGrubuNavigation { get; set; }
        public virtual Aksesuar AksesuarNavigation { get; set; }
        public virtual FileData FileNavigation { get; set; }
        public virtual KataloglarSayfasi KataloglarSayfaNavigation { get; set; }
        public virtual UrunAilesi UrunAilesiNavigation { get; set; }
        public virtual UrunGrubu UrunGrubuNavigation { get; set; }
        public virtual UrunSerisi UrunSerisiNavigation { get; set; }
        public virtual Urunler UrunlerNavigation { get; set; }
    }
}
