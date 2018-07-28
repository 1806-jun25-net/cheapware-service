﻿using System;
using System.Collections.Generic;

namespace Cheapware.Data.Models
{
    public partial class Customers
    {
        public Customers()
        {
            PartsOrders = new HashSet<PartsOrders>();
        }

        public int CustomerId { get; set; }
        public string UserName { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }

        public ICollection<PartsOrders> PartsOrders { get; set; }
    }
}
