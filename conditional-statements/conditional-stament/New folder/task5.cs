using System;

namespace task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tervetuloa");
            Console.Write("Syötä ikäsi: ");
            double ticetPrice = 100;
            double discount = 0;
            string userInput = Console.ReadLine();
            int age = int.Parse(userInput);

            if (age < 7)
            {
                Console.WriteLine("Alle 7v ilmaiseksi");
            }
            else if (age >= 65)
            {
                Console.WriteLine("65c ja yli saavat 50% alennuksen");
            }
            else if (age >= 7 && age < 15)
            {
                Console.WriteLine("Lipun hinta 16€");
            }
            else 
            {
                Console.Write("Oletko MTK:n jäsen [K/E]: ");
                string isMTK = Console.ReadLine();
                
                if(isMTK.ToUpper()=="K")
                {
                    discount = 0.15;
                }

                Console.Write("Oletko varusmies [K/E]: ");
                string isSoldier = Console.ReadLine();
                if (isSoldier.ToUpper() == "K")
                {
                    discount = 0.5;
                }


            }


            Console.WriteLine($"Lipun hinta sinulle on: {ticetPrice - ticetPrice * discount}");
            Console.ReadKey();

        }
    }
}

