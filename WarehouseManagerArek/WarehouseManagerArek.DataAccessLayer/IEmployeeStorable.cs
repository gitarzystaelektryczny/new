using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagerArek.DataAccessLayer
{
    public interface IEmployeeStorable
    {
        void AddEmployee(Models.Employee employee);
        List<Models.Employee> GetEmployees();
        void UpdateEmployee(Models.Employee employee);
        void DeleteEmployee(Models.Employee employee);
    }
}
