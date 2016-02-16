using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagerArek.Models;
using System.Net;
using System.Xml.Linq;
using System.Xml.XPath;

namespace WarehouseManagerArek.CurrencyXml
{
    public class CurrencyRate
    {
        public static List<Currency> GetCurrency()
        {          
            string url = "http://www.nbp.pl/kursy/xml/lasta.xml";
            string xml;

            try
            {
                using (var webClient = new WebClient())
                {
                    xml = webClient.DownloadString(url);
                }
            }
            catch (Exception)
            {
                throw new Exception("Bład połączenia!");
            }

            try
            {
                XDocument doc = XDocument.Parse(xml);
                List<Currency> currencyList = (
                    from pozycja in doc.Root.Elements("pozycja")
                    select new Currency(
                        pozycja.Element("nazwa_waluty").Value,
                        decimal.Parse(pozycja.Element("przelicznik").Value),
                        pozycja.Element("kod_waluty").Value,
                        decimal.Parse(pozycja.Element("kurs_sredni").Value))).ToList();

                return currencyList;
            }
            catch (Exception)
            {

                throw new Exception("Błąd z plikiem Xml!");
            }
           
        }
    }
}


