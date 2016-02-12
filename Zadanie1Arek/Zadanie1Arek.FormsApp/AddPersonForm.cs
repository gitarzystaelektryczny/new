using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zadanie1Arek.PersonManager;

namespace Zadanie1Arek.FormsApp
{
    public partial class AddPersonForm : Form
    {
               
        Person person = new Person();
        ErrorProvider errorProvider = new ErrorProvider();

        IStorable _storage;

        public AddPersonForm(IStorable storage)
        {
            this._storage = storage;
            InitializeComponent();
        }

        
        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            person.FirstName = textBoxFirstName.Text;
        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {
            person.LastName = textBoxLastName.Text;
        }

        private void textBoxAge_TextChanged(object sender, EventArgs e)
        {
            if (textBoxAge.Text != "")
            {
                int wiek;

                if (int.TryParse(textBoxAge.Text, out wiek))
                {
                    person.Age = wiek;
                }
                else
                {
                    errorProvider.SetError(textBoxAge, "Musisz wpisać wartość liczbową!");
                    textBoxAge.Text = "";
                }
            }
        }

        private void textBoxPesel_TextChanged(object sender, EventArgs e)
        {
            if (Validators.IsDigit(textBoxPesel.Text))
            {
                person.Pesel = textBoxPesel.Text;
            }
            else
            {
                errorProvider.SetError(textBoxPesel, "Musisz podać wartość liczbową!");
                textBoxPesel.Text = "";
            }
            
        }

        private void textBoxPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (Validators.IsDigit(textBoxPhoneNumber.Text))
            {
                person.PhoneNumber = textBoxPhoneNumber.Text;
            }
            else
            {                
                errorProvider.SetError(textBoxPhoneNumber, "Musisz wpisać wartość liczbową!");
                textBoxPhoneNumber.Text = "";
            }
}

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (Validators.IsPersonNotEmpty(person))
            {
                _storage.AddPerson(person);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                labelFillMissingFields.Visible = true;
            }

}
    }
}
