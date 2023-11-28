using System;

class Program
{
    static void Main()
    {

        Dictionary<string, double> products = new Dictionary<string, double>
        {
            {"1", 7000.0},
            {"2", 12000.0},
            {"3", 25000.0},
            {"4", 30000.0},
            {"5", 40000.0},
            {"6", 45000.0},
            {"7", 50000.0},
            {"8", 60000.0},
            {"9", 65000.0},


        };
        Dictionary<int, int> moneyDenominations = new Dictionary<int, int>
        {

            {200000, 200000},
            {150000, 150000},
            {100000, 100000},
            {50000, 50000},
            {10000, 10000},
        };

        List<string> selectedProducts = new List<string>();
        double totalPrice = 0.0;

        Console.Clear();
        Console.WriteLine("welcome");
        Console.WriteLine("Snacky iphone Shop");

        while (true)
        {
            Console.WriteLine("");
            Console.WriteLine("   Product                 price");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("1. iphone 4s           7,000 บาท");
            Console.WriteLine("2. iphone 5           12,000 บาท");
            Console.WriteLine("3. iphone 8 Plus      25,000 บาท");
            Console.WriteLine("4. iphone Xs          30,000 บาท");
            Console.WriteLine("5. iphone 13          40,000 บาท");
            Console.WriteLine("6. iphone 13 promax   45,000 บาท");
            Console.WriteLine("7. iphone 14          50,000 บาท");
            Console.WriteLine("8. iphone 14 promax   60,000 บาท");
            Console.WriteLine("9. iphone 15          65,000 บาท");
            Console.WriteLine("--------------------------------");
            Console.Write("\nPls select product or pay (press pay and enter) : ");
            string input = Console.ReadLine();

            if (input.ToLower() == "pay")
            {
                break;
                Console.Clear();
            }

            if (products.ContainsKey(input))
            {
                selectedProducts.Add(input);
                totalPrice += products[input];
                Console.WriteLine($"{input} Product added to cart");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Do you want anything more ?");
            }
            else
            {
                Console.WriteLine("Not found try again");
            }
        }
        Console.WriteLine($"\ntotal price: {totalPrice} บาท");

        double payment = 0.0;
        while (payment < totalPrice)
        {
            Console.Clear();
            Console.Write("Please pay the specified amount");
            Console.Write(" (200000 , 150000 , 100000 , 50000, 10000): ");
            int.TryParse(Console.ReadLine(), out int paymentDenomination);

            if (moneyDenominations.ContainsKey(paymentDenomination))
            {
                moneyDenominations[paymentDenomination]++;
                payment += paymentDenomination;
            }
            else
            {
                Console.WriteLine("Try agian");
                Console.WriteLine("----------------------------------------");
            }
        }
        double change = payment - totalPrice;
        Console.WriteLine("----------------------------------------");
        Console.WriteLine($"Change: {change} บาท");
        Console.WriteLine("\nThank you enjoy and your new phone!");
        Console.WriteLine("----------------------------------------");

    }
}