using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagerPiotrek.Models
{
    /// <summary> Produkt </summary>
    public class Product
    {
        /// <summary> Id produktu </summary>
        public int Id { get; set; }
        /// <summary> Nazwa </summary>
        public string Name { get; set; }
        /// <summary> Kategoria produktu </summary>
        public ProductCategory Category { get; set; }
        /// <summary> Kod kreskowy </summary>
        public int Barcode { get; set; }
        /// <summary> Cena </summary>
        public decimal Price { get; set; }
        /// <summary> Ilość </summary>
        public int Quantity { get; set; }
    }
}
