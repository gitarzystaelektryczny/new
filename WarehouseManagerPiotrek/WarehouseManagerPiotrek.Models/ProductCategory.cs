using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagerPiotrek.Models
{
    /// <summary> Kategoria produktu </summary>
    public class ProductCategory
    {
        /// <summary> Id kategoria produktu </summary>
        public int Id { get; set; }
        /// <summary> Nazwa </summary>
        public string Name { get; set; }
        /// <summary> Opis </summary>
        public string Description { get; set; }
    }
}
