using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagerPiotrek.Models
{
    /// <summary> Klient </summary>
    public class Customer : Person
    {   
        /// <summary> Data rejestracji </summary>
        public DateTime RegistrationDate { get; set; }
    }
}
