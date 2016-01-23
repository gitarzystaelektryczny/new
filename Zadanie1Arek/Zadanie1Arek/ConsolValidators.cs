using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1Arek
{
    public class ConsolValidators
    {
        public static bool IsPesel(string s)   //TODO: stworzyc metodę sprawdzającą ilość cyfr w peselu
        {
            if (s.Length == 11)
            {
                return true;
            }
            return false;
        }

        public static int ToInteger(string s)
        {
            int result;
            do
            {
                if (int.TryParse(s, out result))
                {
                    result = int.Parse(s);
                    return result;  
                }
                else
                {
                    Console.WriteLine("Błąd: Musisz podać wartość liczbową! Spóbuj jeszcze raz!");
                    s = Console.ReadLine();
                }

            } while (result == 0);
            return -1;
        } 

        public static string IsInteger(string s)
        {
            int result;
            do
            {
                if (int.TryParse(s, out result))
                {
                    return s;
                }
                else
                {
                    Console.WriteLine("Błąd: Musisz podać wartość liczbową! Spóbuj jeszcze raz!");
                    s = Console.ReadLine();
                }

            } while (result == 0);
            return " ";
        }
      
        public static void ColourStatement(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(s);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
