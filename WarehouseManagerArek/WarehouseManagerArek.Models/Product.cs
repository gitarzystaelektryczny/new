using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagerArek.Models
{
    class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public int Barcode { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
