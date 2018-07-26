using System;
using System.Collections.Generic;
using System.Text;

namespace Cheapware.Library.Models
{
    public class PowerSupply
    {
        public int PowerSupplyId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Wattage { get; set; }
		public bool Modular { get; set; }
        public decimal Price { get; set; }
    }
}
