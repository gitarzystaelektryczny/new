using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagerArek.Models
{
    public class Currency
    {
        public string Name { get; set; }
        public decimal Converter { get; set; }
        public string Code { get; set; }
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
