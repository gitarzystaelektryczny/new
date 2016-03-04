using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagerPiotrek.CurrencyXml;
using WarehouseManagerPiotrek.Models;

namespace WarehouseManagerPiotrek.ConsoleApp
{
    public class ConsoleTest
    {
        /// <summary> 
        /// Wyświetlenie w konsoli listy walut 
        /// </summary>
        internal void ShowCurrency()
        {
            CurrencyRate currencyRate = new CurrencyRate();
            try
            {
                foreach (var i in currencyRate.GetCurrency())
                {
                    Console.WriteLine(i.Name);
                    Console.WriteLine(i.Converter);
                    Console.WriteLine(i.Code);
                    Console.WriteLine(i.AverageExchange);
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadKey();
        }
    }
}