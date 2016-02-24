using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagerArek.Models
{
    /// <summary>
    /// adres
    /// </summary>
    public class Address
    {
        /// <summary>
        /// id(adres)
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// kraj(adres)
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// miasto(adres)
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// kod pocztowy(adres)
        /// </summary>
        public string PostalCode { get; set; }
        /// <summary>
        /// ulica(adres)
        /// </summary>
        public string Street { get; set; }
        /// <summary>
        /// numer domu(adres)
        /// </summary>
        public string HouseNumber { get; set; }
        /// <summary>
        /// numer mieszkania(adres)
        /// </summary>
        public string ApartmentNumber { get; set; }
        /// <summary>
        /// typ adresu(adres)
        /// </summary>
        public AddressType Type { get; set; }
    }
}
