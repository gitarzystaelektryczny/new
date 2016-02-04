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
    public partial class PeopleListForm : Form
    {

        public PeopleListForm()
        {
            InitializeComponent();
        }
        public void ViewList()
        {
            FileStorage fs = new FileStorage();
            dataGridView1.DataSource = fs.GetAllPersons();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            ViewList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddPersonForm addPersonForm = new AddPersonForm();
            addPersonForm.Show();
            this.Hide();
        }

        private void PeopleListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

