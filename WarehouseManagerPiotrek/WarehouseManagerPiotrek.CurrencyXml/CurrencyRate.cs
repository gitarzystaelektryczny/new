using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Xml.Linq;
using System.Xml.XPath;
using WarehouseManagerPiotrek.Models;

namespace WarehouseManagerPiotrek.CurrencyXml
{
    /// <summary> Kurs wymiany walut </summary>
    public class CurrencyRate
    {
        const string url = "http://www.nbp.pl/kursy/xml/lasta.xml";
        /// <summary> Pobieranie strony (xml) do string </summary>
        public string GetXml()
        {
            try
            {
                string xml;
                using (var webClient = new WebClient())
                {
                 return xml = webClient.DownloadString(url);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Błąd z plikiem XML:", ex);
            }
        }
        /// <summary> Parsowanie na xml, zwrócenie listy walut </summary>
        public List<Currency> GetCurrency(string xml)
        {
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
            catch (Exception ex)
            {
                throw new Exception("Błąd z plikiem XML:", ex);
            }
        }
    }
}