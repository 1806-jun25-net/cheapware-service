using System;
using System.Collections.Generic;
using System.Text;

namespace Cheapware.Data.Models
{
    public class Cart
    {
        public int CartId { get; set; }
        public string ProductId { get; set; }
        public int CustomerId { get; set; }
    }
}
