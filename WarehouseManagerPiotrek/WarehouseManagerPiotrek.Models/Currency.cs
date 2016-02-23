using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagerPiotrek.Models
{   
    /// <summary> Waluta  </summary>
    public class Currency
    {
        /// <summary> Id waluta  </summary>
        public int Id { get; set; }
        /// <summary> Nazwa waluty </summary>
        public string Name { get; set; }
        /// <summary> Przelicznik  </summary>
        public decimal Converter { get; set; }
        /// <summary> Symbol waluty </summary>
        public string Code { get; set; }
        /// <summary> Średni kurs </summary>
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
