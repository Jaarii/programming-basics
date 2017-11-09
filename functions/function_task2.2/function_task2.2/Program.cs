using System;

namespace function_task2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1 = 0;
            int luku2 = 0;
               
            Console.WriteLine("Syötä luku 1: ");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine(luku1);

            Console.WriteLine("Syötä luku 2: ");
            luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine(luku2);



            string number = getNumber(luku1, luku2);
            Console.WriteLine(number);
            Console.ReadKey();
        }
        static string getNumber(int luku1, int luku2)
        {
            string res1;
            string res2; 
            if (luku1 < luku2)
            {
                return res1 = "Luku 1 pienempi kuin luku 2";
            }
            else
            {
               return res2 = "Luku 2 on pienempi kuin luku 1";
            }

        }
    }
}
