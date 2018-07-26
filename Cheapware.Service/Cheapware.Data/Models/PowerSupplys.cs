﻿using System;
using System.Collections.Generic;

namespace Cheapware.Data.Models
{
    public partial class PowerSupplys
    {
        public int PowerSupplyId { get; set; }
        public string Name { get; set; }
        public string Wattage { get; set; }
        public bool Modular { get; set; }
        public decimal Price { get; set; }
        public string Img { get; set; }

        public Inventorys NameNavigation { get; set; }
    }
}
