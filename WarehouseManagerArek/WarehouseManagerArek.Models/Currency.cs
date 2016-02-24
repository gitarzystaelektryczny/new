using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagerArek.Models
{
    /// <summary>
    /// waluta
    /// </summary>
    public class Currency
    {
        /// <summary>
        /// id(waluta)
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// nazwa(waluta)
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// przelicznik(waluta)
        /// </summary>
        public decimal Converter { get; set; }
        /// <summary>
        /// symbol(waluta)
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// średni kurs(waluta)
        /// </summary>
        public decimal AverageExchange { get; set; }

        public Currency(string name, decimal converter, string code, decimal averageExchange)
        {
            Name = name;
            Converter = converter;
            Code = code;
            AverageExchange = averageExchange;
        }
    }

}
