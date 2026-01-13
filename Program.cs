using CSharp_Base_Toolkit.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Base_Toolkit
{
    internal class Programm
    {      
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== C# Base Toolkit ===");
                Console.WriteLine("1) Calculator");
                Console.WriteLine("2) Percent Helper");               
                Console.WriteLine("3) Mini Notes");
                Console.WriteLine("0) Exit");
                Console.WriteLine();

                Console.Write("Choose an option: ");
                ConsoleKeyInfo charKey = Console.ReadKey();
                Console.Clear();

                switch (charKey.Key)
                {
                    case ConsoleKey.D1:
                        Calculator.Run();
                        break;

                    case ConsoleKey.D2:
                        Percent.Run();
                        break;

                    case ConsoleKey.D3:
                        Notes.Run();
                        break;

                    case ConsoleKey.D0:
                        return;
                }

                Console.WriteLine();
                Console.WriteLine("Press ENTER to return to menu...");
                Console.ReadLine();
            }
        }
    }
}
