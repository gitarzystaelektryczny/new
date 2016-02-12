using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zadanie1Piotrek.PersonManager;
using Zadanie1Piotrek.DbRepository;

namespace Zadanie1Piotrek.FormsApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PeopleListForm(new DbStorage()));
        }
    }
}
