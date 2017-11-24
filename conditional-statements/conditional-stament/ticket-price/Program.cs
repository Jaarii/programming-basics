using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ticket_price
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tervetuloa");
            Console.Write("Syötä ikäsi: ");
            double ticetPrice = 16;
            double discount = 0;
            string userInput = Console.ReadLine();
            int age = int.Parse(userInput);

            if (age < 7)
                discount = 1.0;
            else if (age >= 65)
                discount = 0.5;
            else if (age >= 7 && age< 15)
                discount = 0.5;
            else
            {
                Console.Write("Oletko MTK:n jäsen [K/E]: ");
                string isMTK = Console.ReadLine();

                if (isMTK.ToUpper() == "K")
                    discount = 0.15;

                Console.Write("Oletko opiskelija [K/E]: ");
                string isStudent= Console.ReadLine();

                if (isStudent.ToUpper() == "K")
                    discount = discount + 0.45;
                else
                {
                    Console.Write("Oletko varusmies [K/E]: ");
                    string isSoldier = Console.ReadLine();
                    if (isSoldier.ToUpper() == "K")
                        discount = 0.5;
                }
            }
            Console.WriteLine($"Lipun hinta sinulle on: {ticetPrice - ticetPrice * discount:f2}e");
            Console.ReadKey();
        }
    }
}
