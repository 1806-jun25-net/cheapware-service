using System;
using System.Collections.Generic;
using System.Text;

namespace Cheapware.Library.Models
{
    public class Inventory
    {
		public string Name { get; set; }
		public int Quantity { get; set; }
		public string Category { get; set; }
		public decimal Price { get; set; }
        public string Image { get; set; }
    }
}
