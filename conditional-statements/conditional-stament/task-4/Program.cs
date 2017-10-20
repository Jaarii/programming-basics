using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define instructions
            Console.WriteLine("Ohjelma selvittää on lukujen järjestyksen syötä 3 lukua.");
            Console.Write("Syötä luku 1/3: ");
            string userInput = Console.ReadLine();
            int x = int.Parse(userInput);

            Console.Write("Syötä luku 2/3: ");
            userInput = Console.ReadLine();
            int y = int.Parse(userInput);

            Console.Write("Syötä luku 3/3: ");
            userInput = Console.ReadLine();
            int z = int.Parse(userInput);

            if (x < y)
            {
                if (x < z)
                {
                    if (y < z)
                    {
                        Console.WriteLine($"järjestys on {x} {y} {z}");
                    }
                    else
                    {
                        Console.WriteLine($"järjestys on {x} {z} {y}");
                    }
                }
                else
                {
                    Console.WriteLine($"järjestys on {z} {x} {y}");
                }
            }
            else
            {
                if (x < z)
                {
                    Console.WriteLine($"järjestys on {y} {x} {z}");
                }
                else
                {
                    if (y < z)
                    {
                        Console.WriteLine($"järjestys on {y} {z} {x}");
                    }
                    else
                    {
                        Console.WriteLine($"järjestys on {z} {y} {x}");
                    }

                }

            }
            Console.ReadKey();

        }
    }
}
