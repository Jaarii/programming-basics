using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            Random q = new Random();
            double n = 0;
            for (int i = 0; i < 100; i++)
            {
                int x = q.Next(0, 51);
                array[i] = x;


                Console.WriteLine($"{i+1}. {array[i]}");
                n = n + x;
                


            }
            double m = n / 100;
            Console.WriteLine($"keskiarvo on {m} ja summa on {n}");
            
            Console.ReadKey();


        }
    }
}
