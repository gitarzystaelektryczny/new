using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagerArek.Models
{
    /// <summary>
    /// przechowywanie listy w pamięci
    /// </summary>
    public class MemoryStorage<T> : Istorable<T>
    {
        
        private List<T> list = new List<T>();
        /// <summary>
        /// dodawanie elementów do listy
        /// </summary>
        /// <param name="element"></param>
        public void AddElement(T element)
        {
            list.Add(element);
        }
        /// <summary>
        /// zwracanie listy
        /// </summary>
        public IEnumerable<T> GetElement()
        {
            return list;
        }
    }
}
