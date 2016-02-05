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
        IStorable _storage;

        public PeopleListForm(IStorable storage)
        {
            this._storage = storage;
            InitializeComponent();
            ViewList();
        }
        private void ViewList()
        {
            dataGridView1.DataSource = _storage.GetAllPersons();
        }

        private void AddPersonButton_Click(object sender, EventArgs e)
        {
            AddPersonForm addPersonForm = new AddPersonForm(new FileStorage());
            if (addPersonForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ViewList();
            }
        }        

        private void PeopleListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

