using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagerArek.Models
{
    /// <summary>
    /// produkt
    /// </summary>
    public class Product
    {
        /// <summary>
        /// id(produkt)
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// nazwa(produkt)
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// kod kreskowy(produkt)
        /// </summary>
        public int Barcode { get; set; }
        /// <summary>
        /// cena(produkt)
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// ilość(produkt)
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// kategoria(produkt)
        /// </summary>
        public ProductCategory Category { get; set; }
    }
}
