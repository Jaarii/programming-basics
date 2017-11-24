using System;

namespace task_4._1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int sixCounter = 0;
            for (int i = 0; i < 1000; i++)
            {
                int rndValue = rnd.Next(1, 7);
                if (rndValue == 6)
                    sixCounter++;

                Console.WriteLine($"{i+1}.\t{rndValue}");
            }
            Console.WriteLine($"Kutonen esiintyi {sixCounter} kertaa.");
            Console.ReadKey();
        }
    }
}
