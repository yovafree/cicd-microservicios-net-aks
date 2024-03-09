using System;
using System.Collections.Generic;

namespace Payment.API.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public DateTime CreationDate { get; set; }
        public string ClientName { get; set; }
        public string Address { get; set; }
        public decimal Total { get; set; }
        public string UuidTransaction { get; set; }
        public string PaymentGateway { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
