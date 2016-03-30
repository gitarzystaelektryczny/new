using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagerArek.Models;

namespace WarehouseManagerArek.DataAccessLayer
{
    public class EmployeeStorage : IEmployeeStorable
    {
        /// <summary>
        /// dodanie pracownika do bazy danych
        /// </summary>
        public void AddEmployee(Models.Employee employee)
        {
            using (DatabaseEntities1 context = new DatabaseEntities1())
            {
                context.Employees.Add(new Employee
                {
                    FirstName = employee.FirstName,
                    LastName = employee.LastName,
                    Mail = employee.Mail,
                    PhoneOffice = employee.OfficePhone,
                    PhoneMobile = employee.MobilePhone,
                    Position = employee.Position,
                    Salary = employee.Salary,
                    EmploymentDate = employee.EmploymentDate
                });
                context.SaveChanges();
            }
        }

        /// <summary>
        /// odczytanie danych pracowników z bazy i zapis do listy
        /// </summary>
        public List<Models.Employee> GetEmployees()
        {
            List<Models.Employee> employees = new List<Models.Employee>();
            using (DatabaseEntities1 context = new DatabaseEntities1())
            {
                var temp = context.Employees.ToList();

                foreach (var i in temp)
                {
                    Models.Employee employee = new Models.Employee();
                    employee.FirstName = i.FirstName;
                    employee.LastName = i.LastName;
                    employee.Mail = i.Mail;
                    employee.OfficePhone = i.PhoneOffice;
                    employee.MobilePhone = i.PhoneMobile;
                    employee.Position = i.Position;
                    employee.Salary = i.Salary;
                    employee.EmploymentDate = i.EmploymentDate;
                    employee.Id = i.Id;
                    employees.Add(employee);
                }
            }
            return employees;
        }

        /// <summary>
        /// edycja danych pracownika
        /// </summary>
        public void UpdateEmployee(Models.Employee employee)
        {
            using (DatabaseEntities1 context = new DatabaseEntities1())
            {
               var employeeToUpdate = from u in context.Employees where u.Id == employee.Id select u;

                if (employeeToUpdate != null)
                {
                    foreach (var i in employeeToUpdate)
                    {
                        i.FirstName = employee.FirstName;
                        i.LastName = employee.LastName;
                        i.PhoneMobile = employee.MobilePhone;
                        i.PhoneOffice = employee.OfficePhone;
                        i.Mail = employee.Mail;
                        i.Position = employee.Position;
                        i.Salary = employee.Salary;
                        i.EmploymentDate = employee.EmploymentDate;
                    }
                    context.SaveChanges();
                }
            }
        }

        /// <summary>
        /// usunięcie pracownika z bazy danych
        /// </summary>
        public void DeleteEmployee(Models.Employee employee)
        {
            using (DatabaseEntities1 context = new DatabaseEntities1())
            {
                var employeeToDelete = (from d in context.Employees where d.Id == employee.Id select d).FirstOrDefault();

                if (employeeToDelete != null)
                {
                    context.Employees.Remove(employeeToDelete);
                    context.SaveChanges();
                }
            }
        }
    }
}
