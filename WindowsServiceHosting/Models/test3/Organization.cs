using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.test3
{
    public partial class Organization
    {
        public Guid Oid { get; set; }
        public string FullName { get; set; }
        public string Profile { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }

        public virtual Party O { get; set; }
    }
}
