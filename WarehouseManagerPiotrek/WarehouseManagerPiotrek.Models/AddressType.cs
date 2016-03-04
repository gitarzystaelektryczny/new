using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagerPiotrek.Models
{   
    /// <summary> 
    /// Typ adresu 
    /// </summary>
    public enum AddressType
    {
        /// <summary> 
        /// Adres zamieszkania 
        /// </summary>
        MainAddress = 1,

        /// <summary> 
        /// Adres do korespondencji 
        /// </summary>
        ForwardingAddress = 2,

        /// <summary> 
        /// Adres zameldowania 
        /// </summary>
        RegisteredAddress = 3

    }
}
