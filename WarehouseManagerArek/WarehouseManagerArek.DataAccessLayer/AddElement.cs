using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagerArek.Models;

namespace WarehouseManagerArek.DataAccessLayer
{
    public class AddElement
    {
        public Models.Employee AddEmployee(string firstName, string lastname, string mobilePhone, string officePhone, string mail,
            string position, decimal salary, DateTime employmentDate)
        {
            Models.Employee employee = new Models.Employee();
            employee.FirstName = firstName;
            employee.LastName = lastname;
            employee.MobilePhone = mobilePhone;
            employee.OfficePhone = officePhone;
            employee.Mail = mail;
            employee.Position = position;
            employee.Salary = salary;
            employee.EmploymentDate = employmentDate;

            return employee;
        }
    }
}
