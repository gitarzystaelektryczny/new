using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagerArek.Models
{
    /// <summary>
    /// transakcja
    /// </summary>
    public class Transaction
    {
        /// <summary>
        /// id(transakcja)
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// lista produktów(transakcja)
        /// </summary>
        public List<Product> ProduktsList { get; set; }
        /// <summary>
        /// sprzedawca(transakcja)
        /// </summary>
        public Employee Seller { get; set; }
        /// <summary>
        /// klient(transakcja)
        /// </summary>
        public Customer Customer { get; set; }
        /// <summary>
        /// data zakupu(transakcja)
        /// </summary>
        public DateTime PurchaseDate { get; set; }
        /// <summary>
        /// waluta zapłaty(transakcja)
        /// </summary>
        public Currency Currency { get; set; }
        /// <summary>
        /// kurs waluty(transakcja)
        /// </summary>
        public Currency ExchangeRate { get; set; }
    }
}
