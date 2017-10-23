using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä luku myös neg. luvut kelpaavat: ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            int k = 1; // Factor which could be 1 or -1

            int even = 0;
            int odd = 0;

            if (number < 0)
            {
                k = -1;
            }

            for (int i = 0; i <= number * k; i++)
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



            Console.WriteLine($"parittomien summa: {odd*k} ja parillisten summa: {even*k}");
            Console.ReadKey();
        }
    }
}
