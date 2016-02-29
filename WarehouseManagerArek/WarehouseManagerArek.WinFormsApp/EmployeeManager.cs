using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseManagerArek.Models;
using WarehouseManagerArek.DataAccessLayer;
using System.Data.SqlClient;
using System.Data.Entity;

namespace WarehouseManagerArek.WinFormsApp
{
    public partial class EmployeeManager : Form
    {
        public EmployeeManager()
        {
            AddTest addTest = new AddTest(5,"Jacek", "Kowalski", "434534553", "345345354", "jacek@gmail.com", "koordynator", 5650, new DateTime(2006, 03, 04));
            InitializeComponent();
        }

       
        private void EmployeeManager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.databaseDataSet.Employee);
            // TODO: This line of code loads data into the 'databaseDataSet1.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter1.Fill(this.databaseDataSet1.Employee);
        }

        private void dataGridViewEmployeeName_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonEditEmployee.Enabled = true;
            buttonDeleteEmployee.Enabled = true;
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            FormAddEmployee formAddEmployee = new FormAddEmployee();
            formAddEmployee.Show();
        }
    }
}

