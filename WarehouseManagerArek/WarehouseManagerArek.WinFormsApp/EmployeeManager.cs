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

namespace WarehouseManagerArek.WinFormsApp
{
    public partial class EmployeeManager : Form
    {
        AddEmployee formAddEmployee = new AddEmployee(new EmployeeStorage()); 
        AddElement addElement = new AddElement();
        Models.Employee selectedEmployee = new Models.Employee();
   
        IEmployeeStorable _storage;

        public EmployeeManager(IEmployeeStorable employeeStorable)
        {
            _storage = employeeStorable;

            _storage.AddEmployee(addElement.AddEmployee("Jacek", "Kowalski", "505 247 018", "54 288 3642", "jacek@gmail.com", "koordynator", 5650, new DateTime(2006, 03, 04)));
            _storage.AddEmployee(addElement.AddEmployee("Józef", "Gołębiewski", "608 313 123", "54 287 4553", "jozin@wp.pl", "sprzedawca", 2450, new DateTime(2001, 01, 23)));
            _storage.AddEmployee(addElement.AddEmployee("Adrian", "Nawrocki", "504 347 035", "54 287 6527", "adrian@gmail.com", "Kasjer", 3650, new DateTime(2000, 03, 04)));
            _storage.AddEmployee(addElement.AddEmployee("Lech", "Siarczyński", "502 079 123", "55 289 3764", "jan16@o2.pl", "sprzedawca", 2650, new DateTime(1999, 12, 12)));
            _storage.AddEmployee(addElement.AddEmployee("Jan", "Nowak", "505 333 555", "55 288 1134", "janusz@gmail.com", "koordynator", 6650, new DateTime(2004, 05, 04)));
            _storage.AddEmployee(addElement.AddEmployee("Alojzy", "Szpener", "607 112 223", "54 287 0078", "alek@wp.pl", "sprzedawca", 2750, new DateTime(2010, 09, 08)));

            InitializeComponent();
        }

        /// <summary>
        /// pobranie danych z bazy przy uruchamianiu
        /// </summary>
        private void EmployeeManager_Load(object sender, EventArgs e)
        {
            this.dataLoad();
        }

        /// <summary>
        /// zdarzenia przy zaznaczaniu komórek w DataGrid
        /// </summary>
        private void dataGridViewEmployeeName_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonEditEmployee.Enabled = true;
            buttonDeleteEmployee.Enabled = true;

            int rowIndex = e.RowIndex;
            dataGridViewEmployeeName.Rows[rowIndex].Selected = true;
        }

        /// <summary>
        /// dodaj nowego pracownika
        /// </summary>
        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            if (formAddEmployee.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.dataLoad();
            }
        }

        /// <summary>
        /// źródło danych w DataGrid
        /// </summary>
        private void dataLoad()
        {
            dataGridViewEmployeeName.DataSource = _storage.GetEmployees();
        }

        /// <summary>
        /// edytuj zaznaczonego pracownika
        /// </summary>
        private void buttonEditEmployee_Click(object sender, EventArgs e)
        {
            EditEmployee formEditEmployee = new EditEmployee(new EmployeeStorage(), selectedEmployee);
            if (formEditEmployee.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.dataLoad();
            }
        }

        /// <summary>
        /// wyświetlenie w Textbox'ach informacji o pracowniku zaznaczonym w DataGrid
        /// </summary>
        private void dataGridViewEmployeeName_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewEmployeeName.SelectedRows.Count > 0)
            {
                selectedEmployee = (Models.Employee)dataGridViewEmployeeName.SelectedRows[0].DataBoundItem;

                textBoxPhoneMobile.Text = selectedEmployee.MobilePhone;
                textBoxPhoneOffice.Text = selectedEmployee.OfficePhone;
                textBoxMail.Text = selectedEmployee.Mail;
                textBoxPosition.Text = selectedEmployee.Position;
                textBoxSalary.Text = decimal.Round(selectedEmployee.Salary, 2).ToString();
                textBoxEmploymentDate.Text = selectedEmployee.EmploymentDate.ToString("yyyy-MM-dd");
            }
        }

        /// <summary>
        /// usuwanie zaznaczonego pracownika z bazy
        /// </summary>
        private void buttonDeleteEmployee_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Czy na pewno chcesz usunąć pracownika z bazy danych?", "Uwaga!", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                _storage.DeleteEmployee(selectedEmployee);
                dataLoad();

                textBoxPhoneMobile.Clear();
                textBoxPhoneOffice.Clear();
                textBoxMail.Clear();
                textBoxPosition.Clear();
                textBoxSalary.Clear();
                textBoxEmploymentDate.Clear();
            }
        }
    }
}

