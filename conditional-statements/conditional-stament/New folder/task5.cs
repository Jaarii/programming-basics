using System;

namespace task_5
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
            {
                Console.WriteLine("Alle 7v ilmaiseksi");
                {
                    Console.WriteLine("Olet alle 7v [K/E]");
                    string isteen = Console.ReadLine();

                    if (isteen.ToUpper() == "K")
                    {
                        discount = 1.0;
                    }

                    else if (age >= 65)
                    {
                        Console.WriteLine("Olet yli 65v [K/E]");
                        string isold = Console.ReadLine();

                        if (isold.ToUpper() == "K")
                        {
                            discount = 0.5;
                        }
                    }
                    else if (age >= 7 && age < 15)
                    {
                        Console.WriteLine("Lipun hinta 16€");

                    }
                    else
                    {

                        Console.Write("Oletko MTK:n jäsen [K/E]: ");
                        string isMTK = Console.ReadLine();

                        if (isMTK.ToUpper() == "K")
                        {
                            discount = 0.15;
                        }
                        else

                            Console.Write("Oletko opiskelija [K/E]");
                        string isMTKopiskelija = Console.ReadLine();

                        if (isMTKopiskelija.ToUpper() == "K") ;
                        {
                            discount = 0.6;
                        }

                        Console.Write("Oletko varusmies [K/E]: ");
                        string isSoldier = Console.ReadLine();
                        if (isSoldier.ToUpper() == "K")
                        {
                            discount = 0.5;
                        }

                        Console.Write("Oletko opiskelija [K/E]: ");
                        string isstudent = Console.ReadLine();
                        if (isstudent.ToUpper() == "K")
                        {
                            discount = 0.45;
                        }


                    }


                    Console.WriteLine($"Lipun hinta sinulle on: {ticetPrice - ticetPrice * discount}");
                    Console.ReadKey();

                }
            }
        

