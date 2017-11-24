using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Luku\tNeliöjuuri");
            for (int i = 1; i <= 10; i++)
                Console.WriteLine($"{i}\t{Math.Sqrt(i):f2}");
            Console.ReadKey();
        }
    }
}
