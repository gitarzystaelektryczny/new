using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagerArek.WinFormsApp
{
    public class Validators
    {
        public static bool IsDigit(string s)
        {
            decimal temp;

            if (decimal.TryParse(s, out temp))
            {
                return true;
            }
            return false;
        }

        public static bool IsFilled(string s)
        {
            if (s.Length > 0)
            {
                return true;
            }
            return false;
        }
    }
}
