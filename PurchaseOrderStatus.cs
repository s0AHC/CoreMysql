using System;
using System.Collections.Generic;

namespace CoreMysql
{
    public partial class PurchaseOrderStatus
    {
        public PurchaseOrderStatus()
        {
            PurchaseOrders = new HashSet<PurchaseOrders>();
        }

        public int Id { get; set; }
        public string Status { get; set; }

        public ICollection<PurchaseOrders> PurchaseOrders { get; set; }
    }
}
