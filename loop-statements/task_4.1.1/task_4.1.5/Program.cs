using System;

namespace task_4._1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            for(int i=0;i<13;i++)
            {
                double rndValue = rnd.NextDouble();
                if (rndValue < 0.4)
                    Console.WriteLine($"{i+1}. 1\t Kotivoitto\a ");
                else if(rndValue >0.4 && rndValue <0.6)
                    Console.WriteLine($"{i + 1}. X\t Tasapeli");
                else
                    Console.WriteLine($"{i + 1}. 2\t Vierasvoitto ");
            }
            Console.ReadKey();
        }
    }
}
