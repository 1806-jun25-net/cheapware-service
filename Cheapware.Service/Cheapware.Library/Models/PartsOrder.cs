using System;
using System.Collections.Generic;
using System.Text;

namespace Cheapware.Library.Models
{
    class PartsOrder
    {
		public int OrderId { get; set; }
		public int CustomerId { get; set; }
		public decimal FinalPrice { get; set; }
    }

}
