using System;
using System.Collections.Generic;

namespace CoreMysql
{
    public partial class EmployeePrivileges
    {
        public int EmployeeId { get; set; }
        public int PrivilegeId { get; set; }

        public Employees Employee { get; set; }
        public Privileges Privilege { get; set; }
    }
}
