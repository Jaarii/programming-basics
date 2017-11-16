using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_task4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Syötä seuraavaksi 10 lukua");

            Console.Write("Syötä luku 1/10: ");
            string userInput = Console.ReadLine();
            int x1 = int.Parse(userInput);
            if (x1 < 0)
            {
                Console.WriteLine("Luku ei ole hyväksyttävä");

            }

            Console.Write("Syötä luku 2/10: ");
            userInput = Console.ReadLine();
            int x2 = int.Parse(userInput);
            if (x2 < 0)
            {
                Console.WriteLine("Luku ei ole hyväksyttävä");

            }

            Console.Write("Syötä luku 3/10: ");
            userInput = Console.ReadLine();
            int x3 = int.Parse(userInput);
            if (x3 < 0)
            {
                Console.WriteLine("Luku ei ole hyväksyttävä");

            }

            Console.Write("Syötä luku 4/10: ");
            userInput = Console.ReadLine();
            int x4 = int.Parse(userInput);
            if (x4 < 0)
            {
                Console.WriteLine("Luku ei ole hyväksyttävä");

            }

            Console.Write("Syötä luku 5/10: ");
            userInput = Console.ReadLine();
            int x5 = int.Parse(userInput);
            if (x5 < 0)
            {
                Console.WriteLine("Luku ei ole hyväksyttävä");

            }

            Console.Write("Syötä luku 6/10: ");
            userInput = Console.ReadLine();
            int x6 = int.Parse(userInput);
            if (x6 < 0)
            {
                Console.WriteLine("Luku ei ole hyväksyttävä");

            }

            Console.Write("Syötä luku 7/10: ");
            userInput = Console.ReadLine();
            int x7 = int.Parse(userInput);
            if (x7 < 0)
            {
                Console.WriteLine("Luku ei ole hyväksyttävä");

            }

            Console.Write("Syötä luku 8/10: ");
            userInput = Console.ReadLine();
            int x8 = int.Parse(userInput);
            if (x8 < 0)
            {
                Console.WriteLine("Luku ei ole hyväksyttävä");

            }

            Console.Write("Syötä luku 9/10: ");
            userInput = Console.ReadLine();
            int x9 = int.Parse(userInput);
            if (x9 < 0)
            {
                Console.WriteLine("Luku ei ole hyväksyttävä");

            }

            Console.Write("Syötä luku 10/10: ");
            userInput = Console.ReadLine();
            int x10 = int.Parse(userInput);
            if (x10 < 0)
            {
                Console.WriteLine("Luku ei ole hyväksyttävä");

            }

            string getNfind = getNfind;
            Console.WriteLine(find);
            Console.ReadKey();
        }
        public static string getNfind(int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9, int x10)
        {

            string res;
            {

                res = FindMax(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10);

                Console.WriteLine(res);
                Console.ReadKey();
                {
                    return res;
                }
            }
        }

        private static string FindMax(int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9, int x10)
        {
            throw new NotImplementedException();
        }
    }

}