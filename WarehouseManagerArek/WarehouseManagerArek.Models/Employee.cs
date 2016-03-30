using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagerArek.Models
{
    /// <summary>
    /// pracownik
    /// </summary>
    public class Employee : Person
    {
        /// <summary>
        /// stanowisko(pracownik)
        /// </summary>
        public string Position { get; set; } 

        /// <summary>
        /// pensja(pracownik)
        /// </summary>
        public decimal Salary { get; set; }

        /// <summary>
        /// data zatrudnienia(pracownik)
        /// </summary>
        public DateTime EmploymentDate { get; set; }
    }
}
