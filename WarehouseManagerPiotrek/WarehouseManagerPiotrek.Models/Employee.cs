using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagerPiotrek.Models
{
    /// <summary>
    /// Pracownik
    /// </summary>
    public class Employee : Person
    {
        /// <summary> 
        /// Stanowisko
        /// </summary>
        public string Position { get; set; }

        /// <summary> 
        /// Pensja 
        /// </summary>
        public decimal Salary { get; set; }

        /// <summary>
        /// Data zatrudnienia 
        /// </summary>
        public DateTime EmploymentDate { get; set; }    
    }
}
