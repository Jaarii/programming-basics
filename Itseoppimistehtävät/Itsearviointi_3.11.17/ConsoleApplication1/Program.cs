using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjoita tähän haluamasi sana: ");
            string s = Console.ReadLine();



            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine($"{i}, {s}");
            }

            Console.ReadLine();
        }
    
    }
}
