using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define instructions
            Console.WriteLine("Ohjelma selvittää on syötetty luku pariton tai parillinen.");
            bool isNumber;
                Console.Write("Syötä luku: ");
                // Define variables
                string userInput;
                userInput = Console.ReadLine();

                int evaluatedNumber;
                isNumber = int.TryParse(userInput, out evaluatedNumber);
                
                // program logic
                if (evaluatedNumber % 2 == 0)
            {

                if (evaluatedNumber < 0)

                {
                    Console.WriteLine($"Numero {evaluatedNumber} on negatiivinen");
                }
                else if (evaluatedNumber > 0)
                {
                    Console.WriteLine($"Numero {evaluatedNumber} on positiivinen");
                }
                else
                {
                    Console.WriteLine($"Numero {evaluatedNumber} on nolla");
                }
            }
                else
            {
                Console.WriteLine($"Syötit luvun {evaluatedNumber}, se on pariton");
            }
                Console.ReadKey();
        }
    }
}
