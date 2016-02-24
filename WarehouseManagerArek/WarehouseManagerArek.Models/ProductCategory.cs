using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagerArek.Models
{
    /// <summary>
    /// kategoria produktu
    /// </summary>
    public class ProductCategory
    {
        /// <summary>
        /// id(kategoria produktu)
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// nazwa(kategoria produktu)
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// opis(kategoria produktu)
        /// </summary>
        public string Description { get; set; }
    }
}
