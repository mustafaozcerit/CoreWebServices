using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class UserMid2
    {
        public UserMid2()
        {
            DepartmanlarNavigation = new HashSet<Departmanlar>();
            OnayBekleyenDokumanlar = new HashSet<OnayBekleyenDokumanlar>();
            Yetkilendirme = new HashSet<Yetkilendirme>();
        }

        public Guid Oid { get; set; }
        public string AdiSoyadi { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public Guid? Departmanlar { get; set; }

        public virtual Departmanlar Departmanlar1 { get; set; }
        public virtual PermissionPolicyUser O { get; set; }
        public virtual ICollection<Departmanlar> DepartmanlarNavigation { get; set; }
        public virtual ICollection<OnayBekleyenDokumanlar> OnayBekleyenDokumanlar { get; set; }
        public virtual ICollection<Yetkilendirme> Yetkilendirme { get; set; }
    }
}
