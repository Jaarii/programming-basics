using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä lukuja");
            string s = Console.ReadLine();
            int number = int.Parse(s);
            int i = 0;

            do { 
                if (number == -1)
                {
                    break;
                }
            else
                {
                    i = i + number;
                }
                             
                s = Console.ReadLine();
                number = int.Parse(s);
        }
        while(true);

        Console.WriteLine($"Lukujen summa on{i}");
            Console.ReadKey();

           /* if (s > 0)
            {
                Console.WriteLine("Syötä lisää lukuja");
            }
                
            else (s < 0)
            {
                Console.WriteLine("Syötit negatiivisen numeron");
            }*/
            



        }
    }
}
