using System;
using System.Collections.Generic;

namespace Payment.API.Models
{
    public partial class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int Quantity { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Subtotal { get; set; }
        public int OrderId { get; set; }

        public virtual Order Order { get; set; }
    }
}
