using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagerArek.CurrencyXml;

namespace WarehouseManagerArek.ConsoleApp
{
    class ConsoleTest
    {   
        public void ShowCurrency()
        {
            try
            {
                foreach (var i in CurrencyRate.GetCurrency())
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
