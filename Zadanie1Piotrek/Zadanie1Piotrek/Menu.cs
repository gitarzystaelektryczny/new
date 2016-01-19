using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1Piotrek
{
    class Menu
    {
        ListPerson oListPerson = new ListPerson();

        public void Show()
        {
            Console.WriteLine("MENU:\n1- Dodaj osobę\n2- Wyświetl Listę osób\n3- Wyjście z Aplikacji");
            int i = Convert.ToInt32(Console.ReadLine());

            switch (i)
            {
                case 1:
                    oListPerson.AddPerson();
                    Show();
                    break;
                case 2:
                    oListPerson.ShowPeople();
                    Show();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Show();                                 
                    break;
            }
        }
       
    }
}
