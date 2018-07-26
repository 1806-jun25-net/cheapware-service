﻿using System;
using System.Collections.Generic;

namespace Cheapware.Data.Models
{
    public partial class Cpus
    {
        public int Cpuid { get; set; }
        public string Name { get; set; }
        public string Speed { get; set; }
        public int Cores { get; set; }
        public decimal Price { get; set; }
        public string Img { get; set; }

        public Inventorys NameNavigation { get; set; }
    }
}
