using System;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            string input = Console.ReadLine();
            int min = int.MaxValue;
            int sum = 0;
            while(input != "Stop")
            {
                number = int.Parse(input);
                sum += number;
                    if (number < min)
                {
                    min = number;
                }
                input = Console.ReadLine();
            }
            if(input == "Stop")
            {
                sum += number;
                if (number < min)
                {
                    min = number;
                }
            }
            Console.WriteLine(min);
        }
    }
}
