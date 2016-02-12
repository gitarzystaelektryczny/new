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
using Zadanie1Arek.DbRepository;

namespace Zadanie1Arek.FormsApp
{
    public partial class PersonListForm : Form
    {
        IStorable _storage;
        
        public PersonListForm(IStorable storage)
        {
            this._storage = storage;
            InitializeComponent();
            ViewList();   
        }

        public void ViewList()
        {
            dataGridView1.DataSource = _storage.GetAllPersons();
        }     

        private void buttonAddPerson_Click(object sender, EventArgs e)
        {
            AddPersonForm addPersonForm = new AddPersonForm(new DbStorage());
            if (addPersonForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ViewList();
            }
        }

        private void PersonListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
