using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagerArek.Models
{
    /// <summary>
    /// typ adresu
    /// </summary>
    public enum AddressType
    {
        /// <summary>
        /// adres zamieszkania
        /// </summary>
        MainAddress = 1,

        /// <summary>
        /// adres do korespondencji
        /// </summary>
        ForwardingAddress = 2,

        /// <summary>
        /// adres zameldowania
        /// </summary>
        RegisteredAddress = 3
    }
}
