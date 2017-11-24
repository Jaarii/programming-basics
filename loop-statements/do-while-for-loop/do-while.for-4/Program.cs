using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while.for_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä luku XXX: ");
            string userInput = Console.ReadLine();
            int luku = int.Parse(userInput);

            int i = 0;
            int f = 0;

            if (luku > 0)
            {
                for (i = 0; i <= luku; i++) // => i = i + 1;
                {
                    f = f + i;
                }
            }
            else
            {
                for (i = 0; i >= luku; i--) // => i = i + 1;
                {
                    f = f + i;
                }
            }

            Console.WriteLine($"Lukujen 1...{luku} summa = {f}");
            Console.ReadKey();
        }
    }
}
