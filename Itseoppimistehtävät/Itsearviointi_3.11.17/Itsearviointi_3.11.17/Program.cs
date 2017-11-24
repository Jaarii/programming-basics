using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itsearviointi_3._11._17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjoita tähän haluamasi sana: ");
            string s = Console.ReadLine();



            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}, {s}");
            }

            Console.ReadLine();
        }
    }
}
