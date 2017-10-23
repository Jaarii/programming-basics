using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while.for_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä luku: ");
            string userInput = Console.ReadLine();
            int luku = int.Parse(userInput);

            int even = 0;
            int odd = 0;

            if (luku > 0)
            {

                for (int i = 0; i <= luku; i++)
                {
                    if (i % 2 == 0)
                    {
                        even = even + i;
                    }

                    else
                    {
                        odd = odd + i;
                    }
                }
            }

            else
            {

                for (int i = 0; i >= luku; i--)
                {
                    if (i % 2 == 0)
                    {
                        even = even + i;
                    }

                    else
                    {
                        odd = odd + i;
                    }
                }
            }
            Console.WriteLine($"parittomien summa: {odd} ja parillisten summa: {even}");
            Console.ReadKey();
        }
    }
}

