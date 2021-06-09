using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class IkVizyonPolitika
    {
        public IkVizyonPolitika()
        {
            Banner = new HashSet<Banner>();
        }

        public Guid Oid { get; set; }
        public string Baslik { get; set; }
        public string Vizyonumuz { get; set; }
        public string Politikamiz { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public string EngBaslik { get; set; }
        public string EngVizyonumuz { get; set; }
        public string EngPolitikamiz { get; set; }
        public DateTime? SonGuncellemeTarihi { get; set; }

        public virtual ICollection<Banner> Banner { get; set; }
    }
}
