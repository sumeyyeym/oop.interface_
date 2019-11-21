using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.interface_
{
    public class Employees
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HomePhone { get; set; }
        public string Mail { get; set; }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }

    public class Product
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public string CategoryName { get; set; }

        public override string ToString()
        {
            return this.ProductName;
        }
    }

    public class Shipper
    {
        public string CompanyName { get; set; }
        public string Phone { get; set; }

        public override string ToString()
        {
            return this.CompanyName;
        }
    }
}
