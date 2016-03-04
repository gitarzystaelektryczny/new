using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagerPiotrek.Models
{
    /// <summary> 
    /// Osoba 
    /// </summary>
    public abstract class Person
    {
        /// <summary> 
        /// Id osoba 
        /// </summary>
        public int Id { get; set; }

        /// <summary> 
        /// Imię
        /// </summary>
        public string FirstName { get; set; }

        /// <summary> 
        /// Nazwisko 
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Numer prywatny
        /// </summary>
        public string MobilePhone { get; set; }

        /// <summary> 
        /// Numer służbowy 
        /// </summary>
        public string OfficePhone { get; set; }
  
        /// <summary> 
        /// Adres email 
        /// </summary>
        public string Email { get; set; }

        /// <summary> 
        /// adres zamieszkania 
        /// </summary>
        public Address MainAddress { get; set; }

        /// <summary> 
        /// adres do korespondencji 
        /// </summary>
        public Address ForwardingAddress { get; set; }

        /// <summary> 
        /// adres zameldowania
        /// </summary>
        public Address RegisteredAddress { get; set; }

    }
}
