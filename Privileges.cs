using System;
using System.Collections.Generic;

namespace CoreMysql
{
    public partial class Privileges
    {
        public Privileges()
        {
            EmployeePrivileges = new HashSet<EmployeePrivileges>();
        }

        public int Id { get; set; }
        public string PrivilegeName { get; set; }

        public ICollection<EmployeePrivileges> EmployeePrivileges { get; set; }
    }
}
