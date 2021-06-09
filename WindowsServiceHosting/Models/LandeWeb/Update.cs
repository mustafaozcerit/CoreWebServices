using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class Update
    {
        public int UpdateId { get; set; }
        public DateTime Date { get; set; }
        public string AutoManual { get; set; }
    }
}
