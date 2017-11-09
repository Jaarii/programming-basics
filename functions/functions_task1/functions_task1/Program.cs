using System;

namespace functions_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Functions - Task 1.\n");

            int n;
            while (true)
            {
                Console.Write("Tähtien lukumäärä: ");
                n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    Console.WriteLine("Luku {0} ei ole sallittu luku", n);
                }
                else
                {
                    break;
                }
            }
            string asterisks = getNAsterisks(n);
            Console.WriteLine(asterisks);
            Console.ReadKey();
        }

        static string getNAsterisks(int nro)
        {
            string res = string.Empty;
            for (int i = 0; i < nro; i++)
            {
                res += '*';
            }
            return res;
        }
    }
}