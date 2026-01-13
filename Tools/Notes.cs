using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharp_Base_Toolkit.Tools
{
    static class Notes
    {
        public static void Run()
        {
            List<string> notes = new List<string>();

            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string projectDir = FindProjectRoot(baseDir);

            string dataDir = Path.Combine(projectDir, "Data");
            string path = Path.Combine(dataDir, "notes.txt");

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Mini Notes ===");
                Console.WriteLine("1) Add Note");
                Console.WriteLine("2) View Notes");
                Console.WriteLine("3) Save Notes");                
                Console.WriteLine("0) Back to Main Menu");
                Console.WriteLine();
                Console.Write("Choose an option: ");
                ConsoleKeyInfo charKey = Console.ReadKey();
                Console.Clear();

                switch (charKey.Key)
                {
                    case ConsoleKey.D1:
                        Console.Write("Enter your note: ");
                        string note = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(note))
                            Console.WriteLine("Invalid note. Please try again.");
                        else
                        {
                            notes.Add(note);
                            Console.WriteLine("Note added!");
                        }
                        break;

                    case ConsoleKey.D2:
                        Console.WriteLine("=== Your Notes ===");
                        if (notes.Count == 0)
                        {
                            Console.WriteLine("No notes available.");
                        }
                        else
                        {
                            for (int i = 0; i < notes.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {notes[i]}");
                            }
                        }
                        break;

                    case ConsoleKey.D3:
                        Directory.CreateDirectory(dataDir);
                        File.WriteAllLines(path, notes);
                        Console.WriteLine("Saved successfully.");
                        Console.WriteLine("File path: " + path);
                        break;                  

                    case ConsoleKey.D0:
                        return;
                }

                Console.WriteLine();
                Console.WriteLine("Press ENTER to continue...");
                Console.ReadLine();
            }
        }

        // Finds project root folder by searching for *.csproj
        static string FindProjectRoot(string startDir)
        {
            DirectoryInfo dir = new DirectoryInfo(startDir);

            while (dir != null)
            {
                if (dir.GetFiles("*.csproj").Length > 0)
                    return dir.FullName;

                dir = dir.Parent;
            }

            return startDir;
        }
    }
}
