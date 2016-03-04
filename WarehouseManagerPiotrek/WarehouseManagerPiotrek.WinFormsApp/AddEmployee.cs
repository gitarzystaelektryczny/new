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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void butAddEmployee_Click(object sender, EventArgs e)
        {
            AddElement Add = new AddElement();
            Add.AddEmployee(txtBoxFirstName.Text, txtBoxLastName.Text, txtBoxMobilePhone.Text, txtBoxOfficePhone.Text,
                            txtBoxMail.Text, txtBoxPosition.Text,Convert.ToDecimal(txtBoxSallary.Text), 
                            Convert.ToDateTime(dateTimePickerEmploymentDate.Value.Date));
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
