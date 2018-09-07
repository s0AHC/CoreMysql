﻿using System;
using System.Collections.Generic;

namespace CoreMysql
{
    public partial class Invoices
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime? DueDate { get; set; }
        public decimal? Tax { get; set; }
        public decimal? Shipping { get; set; }
        public decimal? AmountDue { get; set; }

        public Orders Order { get; set; }
    }
}
