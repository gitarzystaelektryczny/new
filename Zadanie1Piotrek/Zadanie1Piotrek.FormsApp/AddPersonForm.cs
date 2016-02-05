using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zadanie1Piotrek.PersonManager;

namespace Zadanie1Piotrek.FormsApp
{
    public partial class AddPersonForm : Form
    {
        IStorable _storage;
        Person person = new Person();
       
        public AddPersonForm(IStorable storage)
        {
            this._storage = storage;
            InitializeComponent();           
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            person.Imie = txtFirstName.Text;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            person.Nazwisko = txtLastName.Text;
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            if (txtAge.Text != "")
            {
                int wiek;

                if (int.TryParse(txtAge.Text, out wiek))
                {
                    person.Wiek = wiek;
                }
                else
                {
                    MessageBox.Show("Wiek musi być wartością liczbową!");
                    txtAge.Text = "";
                }
            }
        }

        private void txtPesel_TextChanged(object sender, EventArgs e)
        {
            {
                if (txtPesel.Text.Length == 11)
                    try
                    {
                        person.Pesel = txtPesel.Text;
                        lblNotEmpty.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error, karwasz twarz!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPesel.Text = null;
                    }
                else
                {
                    lblNotEmpty.Text = "pesel jest za krótki";
                }
            }
        }
        
        private void AddPersonButton_Click(object sender, EventArgs e)
        {
            if (Validators.PersonNotEmpty(person))
            {
                _storage.AddPerson(person);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                lblNotEmpty.Visible = true;
            }
        }
    }
    }

