﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagerArek.Models
{
    /// <summary>
    /// osoba, klasa bazowa
    /// </summary>
    public abstract class Person 
    {
        /// <summary>
        /// id(osoba)
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// imię(osoba)
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// nazwisko(osoba)
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// numer telefonu prywatnego(osoba)
        /// </summary>
        public string MobilePhone { get; set; }

        /// <summary>
        /// numer telefonu służbowego(osoba)
        /// </summary>
        public string OfficePhone { get; set; }

        /// <summary>
        /// adres mailowy(osoba)
        /// </summary>
        public string Mail { get; set; }

        /// <summary>
        /// adres zamieszkania(osoba)
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
