using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadanie1Piotrek.PersonManager;

namespace Zadanie1Piotrek.ConsoleApp
{
     class Program
    {        
        static void Main(string[] args)
        {
            ConsoleMenu menu = new ConsoleMenu(new FileStorage());
            menu.Ul();
        }
    }
}
