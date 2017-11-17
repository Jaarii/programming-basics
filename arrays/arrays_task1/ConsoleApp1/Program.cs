using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ohjelma arpoo taulukkoon kokonaisluvut väliltä 0 -20");
            int[] array = new int[10];
            Random q = new Random();
            
            for (int i = 0; i < 10; i++)
            {
                array[i] = q.Next(0, 20);
                if (array[i] < 10)
                {
                    Console.WriteLine($"[{i}] = 0{array[i]}");
                }
                else
                {
                    Console.WriteLine($"[{i}] = {array[i]}");
                } 
               


                



            }
            
            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}
