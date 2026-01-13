using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Base_Toolkit.Tools
{
    internal class Input
    {
        public static bool ReadDecimal(string input, out decimal number)
        {
            input = input.Replace(',', '.');
            if (decimal.TryParse(input, out number))
                return true;
            else
            {
                Console.WriteLine("Invalid input! Try again!");
                Console.ReadKey();
                Console.Clear();
            }
            return false;
        }

        public static bool ReadInteger(string input, out int number)
        {           
            if (int.TryParse(input, out number))
                return true;
            else
            {
                Console.WriteLine("Invalid input! Try again!");
                Console.ReadKey();
                Console.Clear();
            }
            return false;
        }
    }
}
