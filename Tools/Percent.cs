using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Base_Toolkit.Tools
{
    static class Percent
    {
        public static void Run()
        {
            decimal number, percent, result;
            int choice; // n - number x - %

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Percent Helper ===");
                Console.WriteLine("Choose an option:");
                Console.WriteLine(" 1) Calculate X% of a number.");
                Console.WriteLine(" 2) Increase a number by X%.");
                Console.WriteLine(" 3) Decrease a number by X%.");
                Console.WriteLine(" 0) Back to main menu.");

                while (true)
                {
                    Console.Write("Enter your choice: ");
                    string input = Console.ReadLine();

                    if (Input.ReadInteger(input, out choice))
                    {
                        if (choice < 0 || choice > 3)
                        {
                            Console.WriteLine("Invalid option. Please choose between 0 and 3.");
                            Console.ReadKey();
                            Console.Clear();
                            continue;
                        }
                        break; 
                    }
                }

                switch (choice)
                {
                    case 1:
                        // Number input
                        while (true)
                        {
                            Console.Write("Enter the number (N): ");
                            string input = Console.ReadLine();

                            if (Input.ReadDecimal(input, out number))
                                break;
                        }
                        // Percent input
                        while (true)
                        {
                            Console.Write("Enter the percent (X): ");
                            string input = Console.ReadLine();

                            if (Input.ReadDecimal(input, out percent))
                                break;
                        }
                        result = number * percent / 100;
                        Console.WriteLine($"Result: {percent}% of {number} = {result};");
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                        break;

                    case 2:
                        // Number input
                        while (true)
                        {
                            Console.Write("Enter the number (N): ");
                            string input = Console.ReadLine();

                            if (Input.ReadDecimal(input, out number))
                                break;
                        }
                        // Percent input
                        while (true)
                        {
                            Console.Write("Enter the percent (X): ");
                            string input = Console.ReadLine();

                            if (Input.ReadDecimal(input, out percent))
                                break;
                        }
                        result = number + (number * percent / 100);
                        Console.WriteLine($"Result: {number} increased by {percent}% = {result};");
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                        break;

                    case 3:
                        // Number input
                        while (true)
                        {
                            Console.Write("Enter the number (N): ");
                            string input = Console.ReadLine();

                            if (Input.ReadDecimal(input, out number))
                                break;
                        }
                        // Percent input
                        while (true)
                        {
                            Console.Write("Enter the percent (X): ");
                            string input = Console.ReadLine();

                            if (Input.ReadDecimal(input, out percent))
                                break;
                        }
                        result = number - (number * percent / 100);
                        Console.WriteLine($"Result: {number} decreased by {percent}% = {result};");
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                        break;

                    case 0:
                        return;
                }
            }
        }
    }
}
