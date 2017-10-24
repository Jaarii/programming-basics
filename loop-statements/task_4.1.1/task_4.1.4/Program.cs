using System;

namespace task_4._1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.WriteLine("Anna heittojen lukumäärä : ");
            int userInput = int.Parse(Console.ReadLine());

            int klaavat = 0;
            int kruunat = 0;

            for(int i = 0; i < userInput; i++)
            {
                int kolikko = rnd.Next(2);

                if(kolikko == 0)
                {
                    klaavat++;
                }
                else
                {
                    kruunat++;
                }
            }
            Console.WriteLine($"*Kruunuja tuli {kruunat} Klaavoja tuli {klaavat}");
            Console.ReadKey();
        }
    }
}
