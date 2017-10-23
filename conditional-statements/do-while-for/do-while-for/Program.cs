using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä luku: ");
            string userInput = Console.ReadLine();
            int luku = int.Parse(userInput);

            int i = 1;
            int f = 1;
            int tulos = 0;

            for(i = 1; i <= luku; i++) // => i = i + 1;
            {
                f = f * i;
                tulos = f;
            }

            Console.WriteLine($"syötit: {luku}! = {tulos}");
            Console.ReadKey();




        }
    }
}
