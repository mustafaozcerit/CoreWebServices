using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class AydinlatmaMetni
    {
        public AydinlatmaMetni()
        {
            Banner = new HashSet<Banner>();
        }

        public Guid Oid { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string Aciklama2 { get; set; }
        public string Aciklama3 { get; set; }
        public string EngBaslik { get; set; }
        public string EngAciklama { get; set; }
        public string EngAciklama2 { get; set; }
        public string EngAciklama3 { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual ICollection<Banner> Banner { get; set; }
    }
}
