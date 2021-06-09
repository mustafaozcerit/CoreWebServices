using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class Person
    {
        public Guid Oid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime? Birthday { get; set; }
        public string Email { get; set; }

        public virtual Party O { get; set; }
        public virtual User User { get; set; }
    }
}
