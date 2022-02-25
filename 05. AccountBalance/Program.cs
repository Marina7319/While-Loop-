using System;

namespace _05._AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double account = 0;
            while (input != "NoMoreMoney")
            {
                double amount = double.Parse(input);
                if (amount > 0)
                {
                    account += amount;
                    Console.WriteLine($"Increase: {amount:f2}");
                    amount = double.Parse(input);
                    input = Console.ReadLine();
                } else
                {
                    Console.WriteLine($"Invalid operation!");
                    break;
                }
            }
            Console.WriteLine($"Total: {account:f2}");
        }
    }
}
