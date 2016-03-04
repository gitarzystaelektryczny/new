using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagerPiotrek.Models
{
    /// <summary> 
    /// Transakcja
    /// </summary>
    public class Transaction
    {
        /// <summary> 
        /// Id transakcji 
        /// </summary>
        public int Id { get; set; }

        /// <summary> 
        /// Lista produktów 
        /// </summary>
        public List<Product> ProductsList { get; set; }

        /// <summary> 
        /// Sprzedawca 
        /// </summary>
        public Employee Seller { get; set; }

        /// <summary> 
        /// Klient
        /// </summary>
        public Customer Customer { get; set; }

        /// <summary> 
        /// Data zakupu
        /// </summary>
        public DateTime PurchaseDate { get; set; }

        /// <summary> 
        /// Kurs waluty 
        /// </summary>
        public Currency ExchangeRate { get; set; }
    }
}
