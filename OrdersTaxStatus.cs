﻿using System;
using System.Collections.Generic;

namespace CoreMysql
{
    public partial class OrdersTaxStatus
    {
        public OrdersTaxStatus()
        {
            Orders = new HashSet<Orders>();
        }

        public byte Id { get; set; }
        public string TaxStatusName { get; set; }

        public ICollection<Orders> Orders { get; set; }
    }
}
