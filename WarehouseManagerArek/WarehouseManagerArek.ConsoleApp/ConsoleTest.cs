using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagerArek.CurrencyXml;

namespace WarehouseManagerArek.ConsoleApp
{
    public class ConsoleTest
    {   
        /// <summary>
        /// Metoda wyświetlająca listę walut w konsoli
        /// </summary>
        public void ShowCurrency()
        {
            CurrencyRate currencyRate = new CurrencyRate();
            try
            {
                foreach (var i in currencyRate.GetCurrency(currencyRate.GetXml()))
                {
                    Console.WriteLine(i.Name);
                    Console.WriteLine(i.Converter);
                    Console.WriteLine(i.Code);
                    Console.WriteLine(i.AverageExchange);
                    Console.WriteLine();
                    Console.ReadKey();
                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
