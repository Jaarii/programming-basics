using System;

namespace task_4._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int tulo = 0;
                     

            Console.WriteLine("Vastaus:");
            for (int i = 1; i <= 9; i++)
            {
                for (int y = 1; y <= 9; y++)
                {
                    tulo = i * y;
                    Console.WriteLine($"{i} x {y} = {tulo};");
                }
            }

            Console.ReadKey();
        }
    }
}
