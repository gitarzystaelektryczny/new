using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagerArek.Models;
using System.Data.Entity;
using System.Data.SqlClient;

namespace WarehouseManagerArek.DataAccessLayer
{
    public class AddTest
    {
        public AddTest(int id, string firstName, string lastname, string mobilePhone, string officePhone, string mail,
            string position, decimal salary, DateTime employmentDate)
        {
            using (DatabaseEntities1 context = new DatabaseEntities1())
            {
                context.Employees.Add(new Employee()
                {
                    Id = id,
                    FirstName = firstName,
                    LastName = lastname,
                    PhoneMobile = mobilePhone,
                    PhoneOffice = officePhone,
                    Mail = mail,
                    Position = position,
                    Salary = salary,
                    EmploymentDate = employmentDate
                });
                
                context.SaveChanges();
                
            }
        }

        //public AddTest()
        //{

        //}

        //public List<Models.Employee> GetAllEmployees()
        //{
        //    List<Models.Employee> employees = new List<Models.Employee>();

        //    using (DatabaseEntities context = new DatabaseEntities())
        //    {
        //        var temp = context.Employees.ToList();
        //        foreach (var i in temp)
        //        {
        //            Models.Employee emp = new Models.Employee();
        //            emp.Id = i.Id;
        //            emp.FirstName = i.FirstName;
        //            emp.LastName = i.LastName;
        //            emp.PhoneOffice = i.PhoneOffice;
        //            emp.PhoneMobile = i.PhoneMobile;
        //            emp.Position = i.Position;
        //            emp.Salary = i.Salary;
        //            emp.EmploymentDate = i.EmploymentDate;
        //            emp.Mail = i.Mail;
        //            employees.Add(emp);
        //        }
        //    }
        //    return employees;


        //}
    }
}
