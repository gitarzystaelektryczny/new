using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagerArek.Models;
using System.Net;
using System.Xml.Linq;

namespace WarehouseManagerArek.CurrencyXml
{
    /// <summary>
    /// Klasa pobierająca aktualny kurs walut i zwracająca listę walut
    /// </summary>
    public class CurrencyRate
    {
        private const string url = "http://www.nbp.pl/kursy/xml/lasta.xml";
        private string xml;
        private List<Currency> currencyList;

        /// <summary>
        /// Pobieranie strony xml do string
        /// </summary>
        private void GetXml()
        {
            try
            {
                using (var webClient = new WebClient())
                {
                   xml = webClient.DownloadString(url);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Nie można pobrać pliku Xml!", ex);
            }  
        }

        /// <summary>
        /// Parsowanie xml i zwracanie listy walut
        /// </summary>
        private void ParseToCurrency()
        {
            try
            {
                XDocument doc = XDocument.Parse(xml);
                currencyList = (
                    from pozycja in doc.Root.Elements("pozycja")
                    select new Currency(
                        pozycja.Element("nazwa_waluty").Value,
                        decimal.Parse(pozycja.Element("przelicznik").Value),
                        pozycja.Element("kod_waluty").Value,
                        decimal.Parse(pozycja.Element("kurs_sredni").Value))).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Błąd pliku Xml!", ex);
            }
               
        }

        public List<Currency> GetCurrency()
        {
            GetXml();
            ParseToCurrency();
            return currencyList;
        }
    }
}


