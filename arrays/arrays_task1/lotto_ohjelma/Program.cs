using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lotto_ohjelma
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lotto = new int[7];
            int[] extraNumbers = new int [2];
            Random q = new Random();
            
            string printRighrLotteryRow = "";
            string printExtraNumbers = "";

            //Arvotaan oikea lottorivi
            for (int i = 0; i < 7; i++)
            {
                int x = q.Next(1, 41);

                //Tarkastetaan samat
                if (lotto.Contains(x))
                    i--;
                else
                    lotto[i] = x;
            }

            Array.Sort(lotto);
            // Tehdään tuloste
            for (int i = 0; i < 7; i++)
            {
                printRighrLotteryRow += $"{lotto[i]} ";
            }

            // Lisänumerot 2 kpl

            for (int i = 0; i < 2; i++)
            {
                int x = q.Next(1, 41);

                //Tarkastetaan samat
                if (lotto.Contains(x) || extraNumbers.Contains(x))
                    i--;
                else
                {
                    extraNumbers[i] = x;
                    printExtraNumbers += $"{extraNumbers[i]} ";
                }
            }




            // Tuplausnumero
            Console.WriteLine($"Oikea loton rivi {printRighrLotteryRow}");
            Console.WriteLine($"Lisänumerot: {printExtraNumbers}");

            Console.ReadKey();


        }
    }
}
