using System;

namespace function_task2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1 = 0;
          
            Console.WriteLine("Syötä luku väliltä 1 - 50");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine(luku1);

   
            string number = getNumber(luku1);
            Console.WriteLine(number);
            Console.ReadKey();
        }
        static string getNumber(int luku1)
        {
            string res;          

            if (luku1 > 1 && luku1 <51)
            {
                res = "Lukusi oli annetulta väliltä ";
            }
            else
            {
                res = "Luku ei ole annetulta väliltä";               
            }
            return res;

        }
    }
}
