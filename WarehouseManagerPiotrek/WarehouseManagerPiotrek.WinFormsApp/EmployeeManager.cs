using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseManagerPiotrek.DataAccessLayer;



namespace WarehouseManagerPiotrek.WinFormsApp
{
    public partial class EmployeeManager : Form
    {
        public EmployeeManager()
        {
            InitializeComponent();

            AddElement test = new AddElement();
            test.AddEmployee("Jan", "Nowak", "500 111 122", "666 333 994",
                             "nowak@wp.pl", "Kierownik", 4213, new DateTime(2010, 07, 01));
            test.AddEmployee("Jurek", "Owsiak", "345 152 836", "154 752 175",
                            "oswiak@wosp.pl", "Sprzedawca", 2031, new DateTime(2012, 08, 10));        
            test.AddEmployee("Adam", "Małysz", "111 222 543", "513 684 399",
                            "malysz@dakar.com", "Kierowca", 3500, new DateTime(2008, 08, 08));
            test.AddEmployee("Rysiek", "Lubicz", "951 628 006", "730 920 820",
                            "rysiu@klan.tvp.pl", "Aktor", 9000, new DateTime(1991, 06, 01));
            test.AddEmployee("Lech", "Wałęsa", "123 543 789", "435 410 002",
                             "l.walesa@bolek.pl", "Elektryk", 10000, new DateTime(1989, 02, 01));
        }
        public void ViewEmployeesTable()
        {
            // TODO: This line of code loads data into the 'databaseNewDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.databaseNewDataSet.Employee);
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            ViewEmployeesTable();          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            butEditEmp.Enabled = true;
            buttDeleteEmp.Enabled = true;
        }
        

        private void buttAddEmp_Click(object sender, EventArgs e)
        {
            AddEmployee AddEmployeeForm = new AddEmployee();
            if (AddEmployeeForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ViewEmployeesTable();
            }
        }
    }
}
