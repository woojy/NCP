﻿using System;
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
        public string promise { get; set; }
        public int count { get; set; }
    }
}