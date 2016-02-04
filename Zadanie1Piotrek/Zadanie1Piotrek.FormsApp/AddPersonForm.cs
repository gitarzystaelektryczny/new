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
        PeopleListForm peopleListForm = new PeopleListForm();
        FileStorage fileStorage = new FileStorage();
        Person person = new Person();
        public AddPersonForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            person.Imie = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            person.Nazwisko = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                person.Wiek = Convert.ToInt32(textBox3.Text);
            }

            //czemu dwa exceptiony idą jeden po drugim?
            catch (Exception ex)
            {                
                MessageBox.Show(ex.Message, "łoo matko!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Text = "";
            }                  
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text.Length ==11)
           try
                {
                    person.Pesel = textBox4.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error, karwasz twarz!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox4.Text = "";
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                if (Validators.PersonNotEmpty(person))
                    {
                    fileStorage.AddPerson(person);
                    peopleListForm.Show();
                    peopleListForm.ViewList();
                    this.Close();
                    }
                else
                    {
                    label6.Visible = true;
                    }
        }

        private void AddPersonForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            peopleListForm.Show();
        }
    }
}
