using System;
using System.Collections.Generic;
using System.Text;

namespace Cheapware.Library.Models
{
    public class Cpu
    {
		public int CPUId { get; set; }
		public string Name { get; set; }
		public string Image { get; set; }
		public string Speed { get; set; }
		public int Cores { get; set; }
        public decimal Price { get; set; }
    }
}
