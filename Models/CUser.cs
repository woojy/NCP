using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace metoo.Models
{
    public class CUser 
    {
        public int id { get; set; }
        public string name { get; set; }
        public string major { get; set; }
        public string promise1 { get; set; }
        public string promise2 { get; set; }
        public string promise3 { get; set; } 
        public int count { get; set; }
    }
}