using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Base_Toolkit.Tools
{
    static class Calculator
    {
        public static void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Calculator ===");

                int a = ReadInt("Enter first number: ");
                int op = ReadOperation("Choose operation: 1(+) 2(-) 3(*) 4(/): ");
                int b = ReadInt("Enter second number: ");

                if (op == 4 && b == 0)
                {
                    Console.WriteLine("Error: cannot divide by 0.");
                }
                else
                {
                    int result = Calculate(a, b, op);
                    Console.WriteLine("Result: " + result);
                }

                Console.WriteLine();
                Console.Write("Again? (y/n): ");
                string again = Console.ReadLine();

                if (again.ToLower() != "y")
                    break;
            }
        }

        static int ReadInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                int number;
                if (int.TryParse(input, out number))
                    return number;

                Console.WriteLine("Not a number. Press any key and try again...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static int ReadOperation(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                int op;
                if (!int.TryParse(input, out op))
                {
                    Console.WriteLine("Not a number. Press any key and try again...");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                if (op < 1 || op > 4)
                {
                    Console.WriteLine("Wrong option. Enter 1, 2, 3 or 4.");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                return op;
            }
        }

        static int Calculate(int a, int b, int op)
        {
            switch (op)
            {
                case 1: return a + b;
                case 2: return a - b;
                case 3: return a * b;
                case 4: return a / b;
                default: return 0;
            }
        }
    }
}
