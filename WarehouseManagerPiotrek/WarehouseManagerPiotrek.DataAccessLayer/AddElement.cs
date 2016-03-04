using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WarehouseManagerPiotrek.DataAccessLayer
{
    public class AddElement
    {
        public void AddEmployee(string imie, string nazwisko, string telMobile, string telOffice, string mail,
                                 string position, decimal salary, DateTime employmentDate)
        {
            using (DatabaseNewEntities context = new DatabaseNewEntities())
            {
                context.Employees.Add(new Employee
                {
                FirstName = imie,
                LastName = nazwisko,
                PhoneMobile = telMobile,
                OfficeMobile = telOffice,
                Mail = mail,
                Position = position,
                Sallary = salary,
                EmploymentDate = employmentDate                
                });
                
                context.SaveChanges();
            }
        }
    }
}
