using System;
using System.Collections.Generic;
using System.Text;

namespace Cheapware.Library.Models
{
    public class ComputerCase
    {
		public int ComputerCaseId { get; set; }
		public string Name { get; set; }
		public string Image { get; set; }
		public string Size { get; set; }
        public decimal Price { get; set; }
    }
}
