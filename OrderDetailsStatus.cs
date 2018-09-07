using System;
using System.Collections.Generic;

namespace CoreMysql
{
    public partial class OrderDetailsStatus
    {
        public OrderDetailsStatus()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int Id { get; set; }
        public string StatusName { get; set; }

        public ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
