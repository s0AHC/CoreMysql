using System;
using System.Collections.Generic;

namespace CoreMysql
{
    public partial class SalesReports
    {
        public string GroupBy { get; set; }
        public string Display { get; set; }
        public string Title { get; set; }
        public string FilterRowSource { get; set; }
        public byte Default { get; set; }
    }
}
