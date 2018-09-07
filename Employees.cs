﻿using System;
using System.Collections.Generic;

namespace CoreMysql
{
    public partial class Employees
    {
        public Employees()
        {
            EmployeePrivileges = new HashSet<EmployeePrivileges>();
            Orders = new HashSet<Orders>();
            PurchaseOrders = new HashSet<PurchaseOrders>();
        }

        public int Id { get; set; }
        public string Company { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string EmailAddress { get; set; }
        public string JobTitle { get; set; }
        public string BusinessPhone { get; set; }
        public string HomePhone { get; set; }
        public string MobilePhone { get; set; }
        public string FaxNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string ZipPostalCode { get; set; }
        public string CountryRegion { get; set; }
        public string WebPage { get; set; }
        public string Notes { get; set; }
        public byte[] Attachments { get; set; }

        public ICollection<EmployeePrivileges> EmployeePrivileges { get; set; }
        public ICollection<Orders> Orders { get; set; }
        public ICollection<PurchaseOrders> PurchaseOrders { get; set; }
    }
}