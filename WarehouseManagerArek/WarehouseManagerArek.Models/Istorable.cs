using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagerArek.Models
{
    public interface Istorable<T>
    {
        void AddElement(T element);
        IEnumerable<T> GetElement();
    }
}
