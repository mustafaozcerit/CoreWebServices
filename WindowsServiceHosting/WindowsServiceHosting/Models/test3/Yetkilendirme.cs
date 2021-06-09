using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.test3
{
    public partial class Yetkilendirme
    {
        public Yetkilendirme()
        {
            OnayBekleyenDokumanlar = new HashSet<OnayBekleyenDokumanlar>();
        }

        public Guid Oid { get; set; }
        public Guid? Departmanlar { get; set; }
        public int? Id { get; set; }
        public Guid? Yetkili { get; set; }
        public string ObjectType { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual Departmanlar DepartmanlarNavigation { get; set; }
        public virtual UserMid2 YetkiliNavigation { get; set; }
        public virtual ICollection<OnayBekleyenDokumanlar> OnayBekleyenDokumanlar { get; set; }
    }
}
