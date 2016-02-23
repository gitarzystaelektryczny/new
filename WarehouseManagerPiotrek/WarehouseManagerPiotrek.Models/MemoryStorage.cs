using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagerPiotrek.Models
{
    /// <summary> Przechowywanie listy </summary>
    public class MemoryStorage<T> : IStorable<T>
    {
        List<T> lista = new List<T>();

        /// <summary> dodawanie elementów listy </summary>
        public void AddElement(T element)
        {
            lista.Add(element);
        }

        public IEnumerable<T> GetElements()
        {
            return lista;
        }
    }
}
