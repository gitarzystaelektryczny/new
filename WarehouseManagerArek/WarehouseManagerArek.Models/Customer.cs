using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagerArek.Models
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address AddressMain { get; set; }
        public Address AddressForwarding { get; set; }
        public Address RegisteredAddress { get; set; }
    }
}
