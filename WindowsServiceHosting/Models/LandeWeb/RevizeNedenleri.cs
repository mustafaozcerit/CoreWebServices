using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class RevizeNedenleri
    {
        public RevizeNedenleri()
        {
            Revizeler = new HashSet<Revizeler>();
        }

        public Guid Oid { get; set; }
        public string RevizeNedeni { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual ICollection<Revizeler> Revizeler { get; set; }
    }
}
