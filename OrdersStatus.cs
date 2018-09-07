using System;
using System.Collections.Generic;

namespace CoreMysql
{
    public partial class OrdersStatus
    {
        public OrdersStatus()
        {
            Orders = new HashSet<Orders>();
        }

        public byte Id { get; set; }
        public string StatusName { get; set; }

        public ICollection<Orders> Orders { get; set; }
    }
}
