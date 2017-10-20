using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                // Define instructions
                Console.WriteLine("Ohjelma selvittää on syötetty luku pariton tai parillinen sekä onko luku pos. neg vai nolla.");
                
                Console.Write("Syötä luku: ");
                // Define variables
                string userInput;
                userInput = Console.ReadLine();

                int evaluatedNumber=int.Parse(userInput);

                //program logic
                // Even or odd
                if (evaluatedNumber % 2 == 0)
                {
                    Console.Write($"Syötit luvun {evaluatedNumber}, se on parillinen ja ");
                }
                else
                {
                    Console.Write($"Syötit luvun {evaluatedNumber}, se on pariton ja ");
                }

                // positive, negative or zero
                if (evaluatedNumber < 0)

                {
                    Console.WriteLine("negatiivinen");
                }
                else if (evaluatedNumber > 0)
                {
                    Console.WriteLine("positiivinen");
                }
                else
                {
                    Console.WriteLine("nolla");
                }

                Console.ReadKey();
            }
        }
    }
}

                