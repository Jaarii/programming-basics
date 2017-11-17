using System;

namespace array_task3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma arpoo kymmenen kokonaislukua väliltä 0 - 100");
            int[] arrT_1 = new int[10];
            int[] arrT_2 = new int[10];
            int[] arrT_3 = new int[10];

            Random q = new Random();
            //taulukoiden alustus alla
            for (int i = 0; i < 10; i++)
            {
                arrT_1[i] = q.Next(0, 100);
                arrT_2[i] = q.Next(0, 100);


            }
            // 3 taulukkoon tiedot taulukoista 1 ja 2 suurimmat
            for (int i = 0; i < 10; i++)
            {
                if (arrT_1[i] < arrT_2[i])
                    arrT_3[i] = arrT_2[i];
                else
                    arrT_3[i] = arrT_1[i];
            }


            // tästä alkaa tulostus
            Console.Write("        ");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i:00} ");
            }
            Console.Write("\n       ");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("---");
            }
            Console.WriteLine();
            Console.WriteLine(PrintToScreen("arrT_1: ", arrT_1));
            Console.WriteLine(PrintToScreen("arrT_2: ", arrT_2));
            Console.WriteLine(PrintToScreen("arrT_3: ", arrT_3));

            //Console.Write("\narrT_1: ");
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write($"{arrT_1[i]:00} ");
            //}
            //Console.Write("\narrT_2: ");
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write($"{arrT_2[i]:00} ");
            //}
            //Console.Write("\narrT_3: ");
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write($"{arrT_3[i]:00} ");
            //}



            Console.ReadKey();
        }
        static string PrintToScreen(string title, int [] xxx)
        {
            string retValue = title;
            for (int i = 0; i < xxx.Length ; i++)
            {
                retValue += $"{xxx[i]:00} ";
            }
            return retValue;
        }
}


}
    

