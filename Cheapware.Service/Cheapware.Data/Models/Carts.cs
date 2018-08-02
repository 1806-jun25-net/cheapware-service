using System;
using System.Collections.Generic;

namespace Cheapware.Data.Models
{
    public partial class Carts
    {
        public int CartId { get; set; }
        public string ProductName { get; set; }
        public int CustomerId { get; set; }

        public Customers Customer { get; set; }
        public Inventorys ProductNameNavigation { get; set; }
    }
}
