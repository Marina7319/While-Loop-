using System;

namespace _03._SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

          int numOne = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i = 1; i > 100; i++)
            {
                int numTwo = int.Parse(Console.ReadLine());
                sum += numTwo;
                if(sum > numTwo)
                {
                    Console.WriteLine(sum);
                    break;

                }
            }
        }
    }
}
