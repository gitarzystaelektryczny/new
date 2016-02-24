using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagerArek.Models
{
    /// <summary>
    /// klient
    /// </summary>
    public class Customer : Person
    {
        /// <summary>
        /// data rejestracji w systemie(klient)
        /// </summary>
        public DateTime RegistrationDate { get; set; }
    }
}
