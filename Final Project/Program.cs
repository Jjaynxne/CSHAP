using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        Dictionary<string, double> products = new Dictionary<string, double>
        {
            {"1", 450.0},
            {"2", 350.0},
            {"3", 490.0},
            {"4", 540.0},
            {"5", 480.0},
            {"6", 540.0},
            {"7", 320.0},
            {"8", 150.0},
            {"9", 540.0},
            {"10", 540.0},
            {"11", 540.0},
            {"12", 240.0},
            {"13", 540.0},
            {"14", 540.0},
            {"15", 540.0}
        };
        Dictionary<int, int> moneyDenominations = new Dictionary<int, int>
        {
            {1000, 1000},
            {500, 500},
            {100, 100},
            {20, 20},
        };

        List<string> selectedProducts = new List<string>();
        double totalPrice = 0.0;

        Console.WriteLine("--------         Welcome To J-KUB          --------");

        while (true)
        {
            Console.WriteLine("--------  PLEASE SELECTED PRODUCT     --------");
                Console.WriteLine("");
                Console.WriteLine("--------     Logitech Brand       --------");
                Console.WriteLine("------ 1.Logitech G-PRO Wireless Superlight Mouse ------");
                Console.WriteLine("------      PRICE = 450 Baht        ------");
                Console.WriteLine("------ 2.Logitech G-PRO Wireless Superlight 2 Mouse -------");
                Console.WriteLine("------      PRICE = 350 Baht        ------");
                Console.WriteLine("------ 3.Logitech G-PRO X Keyboard ------");
                Console.WriteLine("------      PRICE = 490 Baht        ------");
                Console.WriteLine("------ 4.Logitech G913 Keyboard ------");
                Console.WriteLine("------      PRICE = 540 Baht        ------");
                Console.WriteLine("------ 5.Logitech G413 Keyboard -------");
                Console.WriteLine("------      PRICE = 480 Baht        ------");
                Console.WriteLine("");

                Console.WriteLine("--------     Corsair Brand        --------");
                Console.WriteLine("------ 6.Corsair K65 RGB Keyboard -------");
                Console.WriteLine("------      PRICE = 540 Baht        ------");
                Console.WriteLine("------ 7.Corsair K70 PRO Keyboard -------");
                Console.WriteLine("------      PRICE = 320 Baht        ------");
                Console.WriteLine("------ 8.Corsair K55  Keyboard --------");
                Console.WriteLine("------      PRICE = 150 Baht        ------");
                Console.WriteLine("------ 9.Corsair Harpoon G Mouse ------");
                Console.WriteLine("------      PRICE = 540 Baht        ------");
                Console.WriteLine("------ 10.Corsair KATAR ELITE MOUSE ------");
                Console.WriteLine("------      PRICE = 540 Baht        ------");
                Console.WriteLine("");

                Console.WriteLine("--------      RAZER Brand        --------");
                Console.WriteLine("------ 11.Razer DeathAdder V3 Pro Mouse ------");
                Console.WriteLine("------      PRICE = 540 Baht        ------");
                Console.WriteLine("------ 12.Razer DeathAdder Essential Mouse ------");
                Console.WriteLine("------      PRICE = 240 Baht        ------");
                Console.WriteLine("------ 13.Razer Viper Mouse ------");
                Console.WriteLine("------      PRICE = 540 Baht        ------");
                Console.WriteLine("------ 14.Razer Huntman mini Keyboard - Black ------");
                Console.WriteLine("------      PRICE = 540 Baht        ------");
                Console.WriteLine("------ 15.Razer Huntman mini Keyboard - White ------");
                Console.WriteLine("------      PRICE = 540 Baht        ------");
                Console.WriteLine("");


            

            Console.Write(" IF YOUR CHOOSE PRODUCT COLECTLY(KEY DONE) : ");
            string input = Console.ReadLine();

            if (input.ToLower() == "done")
            {
                break;
            }

            if (products.ContainsKey(input))
            {
                selectedProducts.Add(input);
                totalPrice += products[input];
                Console.WriteLine($"{input} ADD TO YOUR CHART ");
            }
            else
            {
                Console.WriteLine(" Can't FIND ");
            }
        }

        Console.WriteLine($"\nTOTAL: {totalPrice} BAHT");

        double payment = 0.0;
        while (payment <= totalPrice)
        {
            Console.Write(" KEY MONEY (1000, 500, 100, 50, 20): ");
            int.TryParse(Console.ReadLine(), out int paymentDenomination);

            if (moneyDenominations.ContainsKey(paymentDenomination))
            {
                moneyDenominations[paymentDenomination]++;
                payment += paymentDenomination;
            }
            else
            {
                Console.WriteLine("Can't done");
            }
        }


        double change = payment - totalPrice;
        Console.WriteLine($"เงินทอน: {change} Baht");
        Console.WriteLine("\nTHANK YOU , Please Enjoy!");
    }
}