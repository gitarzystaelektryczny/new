using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagerPiotrek.Models;

namespace WarehouseManagerPiotrek.Models
{
    public interface IStorable<T>
    {
        void AddElement(T element);
        IEnumerable<T> GetElements();
        
        //TODO  void UpdateElement<T>(T element);
        //TODO  void DeleteElement<T>(T element);
    }
}
