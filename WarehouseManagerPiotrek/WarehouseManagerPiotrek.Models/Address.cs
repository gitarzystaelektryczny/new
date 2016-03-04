using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagerPiotrek.Models
{
    /// <summary> 
    /// Adres 
    /// </summary>
    public class Address
    {
        /// <summary> 
        /// Id adres 
        /// </summary>
        public int Id { get; set; }

        /// <summary> 
        /// Kraj 
        /// </summary>
        public string Country { get; set; }

        /// <summary> 
        /// Miasto 
        /// </summary>
        public string City { get; set; }

        /// <summary> 
        /// Ulica
        /// </summary>
        public string Steet { get; set; }

        /// <summary>
        /// Numer domu
        /// </summary>
        public string HouseNumber { get; set; }

        /// <summary>
        /// Numer mieszkania 
        /// </summary>
        public string ApartmentNumber { get; set; }

        /// <summary> 
        /// Typ adresu 
        /// </summary>
        public AddressType Type { get; set; }
    }
}
