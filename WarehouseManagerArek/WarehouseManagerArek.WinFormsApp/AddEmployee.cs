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
    public partial class AddEmployee : Form
    {
        IEmployeeStorable _storage;
        Models.Employee employee = new Models.Employee();

        public AddEmployee(IEmployeeStorable employeeStorable)
        {
            _storage = employeeStorable;
            InitializeComponent();

            dateTimePickerAddEmplEmploymentDate.Value = DateTime.Now;
        }

        /// <summary>
        /// wprowadź nowego pracownika do bazy, walidacja zawartości textbox'ów, czyszczenie zawartości textbox'ów
        /// </summary>
        private void buttonAddNewEmployee_Click(object sender, EventArgs e)
        {
            if (Validators.IsFilled(textBoxAddEmplFirstName.Text) && Validators.IsFilled(textBoxAddEmplLastName.Text) && Validators.IsFilled(textBoxAddEmplMobilePhone.Text)
                && Validators.IsFilled(textBoxAddEmplOfficePhone.Text) && Validators.IsFilled(textBoxAddEmplMail.Text) && Validators.IsFilled(textBoxAddEmplPosition.Text) && Validators.IsFilled(textBoxAddEmplSalary.Text))
            {
                _storage.AddEmployee(employee);

                textBoxAddEmplFirstName.Clear();
                textBoxAddEmplLastName.Clear();
                textBoxAddEmplMobilePhone.Clear();
                textBoxAddEmplOfficePhone.Clear();
                textBoxAddEmplMail.Clear();
                textBoxAddEmplPosition.Clear();
                textBoxAddEmplSalary.Clear();

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Uzupełnij wszystkie pola!", "Uwaga!", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// podaj imię
        /// </summary>
        private void textBoxAddEmplFirstName_TextChanged(object sender, EventArgs e)
        {
            employee.FirstName = textBoxAddEmplFirstName.Text;
        }

        /// <summary>
        /// podaj nazwisko
        /// </summary>
        private void textBoxAddEmplLastName_TextChanged(object sender, EventArgs e)
        {
            employee.LastName = textBoxAddEmplLastName.Text;
        }

        /// <summary>
        /// walidacja MobilePhone
        /// </summary>
        private void textBoxAddEmplMobilePhone_TextChanged(object sender, EventArgs e)
        {
            if (Validators.IsDigit(textBoxAddEmplMobilePhone.Text))
            {
                employee.MobilePhone = textBoxAddEmplMobilePhone.Text;
                textBoxAddEmplMobilePhone.BackColor = Color.White;
                labelMobilePhone.Visible = false;
            }
            else
            {
                textBoxAddEmplMobilePhone.BackColor = Color.IndianRed;
                labelMobilePhone.Visible = true;
                textBoxAddEmplMobilePhone.Text = "";
            }
        }
   
        /// <summary>
        /// walidacja OfficePhone
        /// </summary>
        private void textBoxAddEmplOfficePhone_TextChanged(object sender, EventArgs e)
        {
            if (Validators.IsDigit(textBoxAddEmplOfficePhone.Text))
            {
                employee.OfficePhone = textBoxAddEmplOfficePhone.Text;
                textBoxAddEmplOfficePhone.BackColor = Color.White;
                labelOfficePhone.Visible = false;
            }
            else
            {
                textBoxAddEmplOfficePhone.BackColor = Color.IndianRed;
                labelOfficePhone.Visible = true;
                textBoxAddEmplOfficePhone.Text = "";
            }
        }

        /// <summary>
        /// podaj mail
        /// </summary>
        private void textBoxAddEmplMail_TextChanged(object sender, EventArgs e)
        {
            employee.Mail = textBoxAddEmplMail.Text;
        }

        /// <summary>
        /// podaj stanowisko
        /// </summary>
        private void textBoxAddEmplPosition_TextChanged(object sender, EventArgs e)
        {
            employee.Position = textBoxAddEmplPosition.Text;
        }

        /// <summary>
        /// walidacja Salary
        /// </summary>
        private void textBoxAddEmplSalary_TextChanged(object sender, EventArgs e)
        {
            if (Validators.IsDigit(textBoxAddEmplSalary.Text))
            {
                employee.Salary = Convert.ToDecimal(textBoxAddEmplSalary.Text);
                textBoxAddEmplSalary.BackColor = Color.White;
                labelSalary.Visible = false;
            }
            else
            {
                textBoxAddEmplSalary.BackColor = Color.IndianRed;
                labelSalary.Visible = true;
                textBoxAddEmplSalary.Text = "";
            } 
        }

        /// <summary>
        /// podaj datę zatrudnienia
        /// </summary>
        private void dateTimePickerAddEmplEmploymentDate_ValueChanged(object sender, EventArgs e)
        {
            employee.EmploymentDate = dateTimePickerAddEmplEmploymentDate.Value;
        }
    }
}
