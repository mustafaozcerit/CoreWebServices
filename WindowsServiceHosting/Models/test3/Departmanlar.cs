using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.test3
{
    public partial class Departmanlar
    {
        public Departmanlar()
        {
            UserMid2 = new HashSet<UserMid2>();
            Yetkilendirme = new HashSet<Yetkilendirme>();
        }

        public Guid Oid { get; set; }
        public string DepartmanAdi { get; set; }
        public Guid? DepartmanMuduru { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual UserMid2 DepartmanMuduruNavigation { get; set; }
        public virtual ICollection<UserMid2> UserMid2 { get; set; }
        public virtual ICollection<Yetkilendirme> Yetkilendirme { get; set; }
    }
}
