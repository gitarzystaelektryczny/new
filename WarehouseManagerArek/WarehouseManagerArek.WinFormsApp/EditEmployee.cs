using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseManagerArek.DataAccessLayer;

namespace WarehouseManagerArek.WinFormsApp
{
    public partial class EditEmployee : Form
    {
        IEmployeeStorable _storage;
        Models.Employee _employee = new Models.Employee();

        public EditEmployee(IEmployeeStorable storage, Models.Employee employee)
        {
            _employee = employee;
            _storage = storage;
            InitializeComponent();
        }

        /// <summary>
        /// wypełnienie textbox'ów (podczas ładowania formatki) danymi wybranego pracownika
        /// </summary>
        private void EditEmployee_Load(object sender, EventArgs e)
        {
            textBoxEditEmplFirstName.Text = _employee.FirstName;
            textBoxEditEmplLastName.Text = _employee.LastName;
            textBoxEditEmplMobilePhone.Text = _employee.MobilePhone;
            textBoxEditEmplOfficePhone.Text = _employee.OfficePhone;
            textBoxEditEmplMail.Text = _employee.Mail;
            textBoxEditEmplPosition.Text = _employee.Position;
            textBoxEditEmplSalary.Text = _employee.Salary.ToString();
            dateTimePickEditEmplEmploymentDate.Value = _employee.EmploymentDate;
        }

        /// <summary>
        /// zapisanie zmian w bazie danych
        /// </summary>
        private void buttonEditNewEmployee_Click(object sender, EventArgs e)
        {
            _employee.FirstName = textBoxEditEmplFirstName.Text;
            _employee.LastName = textBoxEditEmplLastName.Text;
            _employee.MobilePhone = textBoxEditEmplMobilePhone.Text;
            _employee.OfficePhone = textBoxEditEmplOfficePhone.Text;
            _employee.Mail = textBoxEditEmplMail.Text;
            _employee.Position = textBoxEditEmplPosition.Text;
            _employee.Salary = Convert.ToDecimal(textBoxEditEmplSalary.Text);
            _employee.EmploymentDate = dateTimePickEditEmplEmploymentDate.Value;

            _storage.UpdateEmployee(_employee);

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
