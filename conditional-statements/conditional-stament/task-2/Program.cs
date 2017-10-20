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
            Console.WriteLine("Ohjelma selvittää onko syötetty luku pariton tai parillinen.");

            Console.Write("Syötä luku: ");
            // Define variables
            string userInput= Console.ReadLine(); // luetaan käyttäjän syöttämät arvot näppäimistöltä Console.ReadLine() ja tallennetaan ne muuttujaan userInput


            int evaluatedNumber=int.Parse(userInput);
            
            // program logic
            if (evaluatedNumber % 2 == 0)
            {
                Console.WriteLine($"Syötit luvun {evaluatedNumber}, se on parillinen");
            }
            else
            {
                Console.WriteLine($"Syötit luvun {evaluatedNumber}, se on pariton");
            }

            
            Console.ReadKey();
        }
    }
}
