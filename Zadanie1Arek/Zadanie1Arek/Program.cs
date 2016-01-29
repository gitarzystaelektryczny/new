using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadanie1Arek.PersonManager;

namespace Zadanie1Arek
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            ConsoleMenu menu = new ConsoleMenu(new FileStorage()); 
            
            menu.ShowMenu(); 
            
        }

        
    }
}
