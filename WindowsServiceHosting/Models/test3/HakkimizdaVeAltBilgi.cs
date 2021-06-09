using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.test3
{
    public partial class HakkimizdaVeAltBilgi
    {
        public HakkimizdaVeAltBilgi()
        {
            HakkimizdaAltGrup = new HashSet<HakkimizdaAltGrup>();
            YonetimKadrosu = new HashSet<YonetimKadrosu>();
        }

        public Guid Oid { get; set; }
        public string AltBilgi { get; set; }
        public string HakkimizdaBaslk { get; set; }
        public string HakkimizdaAciklama { get; set; }
        public string HakkimizdaBaslk2 { get; set; }
        public string HakkimizdaAciklama2 { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public string EngAltBilgi { get; set; }
        public string EngHakkimizdaBaslk { get; set; }
        public string EngHakkimizdaAciklama { get; set; }
        public string EngHakkimizdaBaslk2 { get; set; }
        public string EngHakkimizdaAciklama2 { get; set; }
        public DateTime? SonGuncellemeTarihi { get; set; }
        public byte[] Fotograf { get; set; }

        public virtual ICollection<HakkimizdaAltGrup> HakkimizdaAltGrup { get; set; }
        public virtual ICollection<YonetimKadrosu> YonetimKadrosu { get; set; }
    }
}
