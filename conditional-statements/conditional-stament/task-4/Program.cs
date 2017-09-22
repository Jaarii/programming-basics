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
            Console.WriteLine("Ohjelma selvittää on syötetty luku pariton tai parillinen.");
            bool isNumber;
            Console.Write("Syötä luku: ");
            // Define variables
            string userInput;
            userInput = Console.ReadLine();

            int evaluatedNumber;
            isNumber = int.TryParse(userInput, out evaluatedNumber);
        }
    }
}
