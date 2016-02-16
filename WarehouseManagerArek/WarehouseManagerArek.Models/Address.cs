using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagerArek.Models
{
    public class Address
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string ApartmentNumber { get; set; }
        public string PhoneMobile { get; set; }
        public string PhoneOffice { get; set; }
        public string Mail { get; set; }

        public enum AddressType
        {
            AddressMain,
            AddressForwarding,
            AddressRegistered 
        }
    }
}
