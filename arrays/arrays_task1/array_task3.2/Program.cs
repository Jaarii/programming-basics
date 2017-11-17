using System;

namespace array_task3._2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ohjelma arpoo taulukkoon kokonaisluvut väliltä 0 -20");
            int[,] array = new int[10, 20];
            Random q = new Random();
            Console.WriteLine("[i, y] = arvo");

            for (int i = 0; i < 10; i++)
            {
                for (int y = 0; y < 20; y++)
                {
                    array[i, y] = q.Next(0, 100);
                    if (array[i, y] < 10)
                    {
                        Console.WriteLine($"[{i},{y}] = 0{array[i, y]}");
                    }
                    else
                    {
                        Console.WriteLine($"[{i}, {y}] = {array[i, y]}");
                    }

                }
            }
            Console.ReadKey();
        } 
        
    }
}
