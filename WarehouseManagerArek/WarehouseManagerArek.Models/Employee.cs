using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagerArek.Models
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public string Position { get; set; }    
        public float Salary { get; set; }
        public DateTime EmploymentDate { get; set; }
        public Address AddressMain { get; set; }
        public Address AddressForwarding { get; set; }
        public Address AddressRegistered { get; set; }
    }
}
