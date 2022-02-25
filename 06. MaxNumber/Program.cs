using System;

namespace _06._MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int gols = 0;
            string input = Console.ReadLine();
            int max = int.MinValue;
            int sum = 0;
            while (input != "Stop")
            {
                gols = int.Parse(input);
                sum += gols;
                if (gols > max)
                {
                    max = gols;
                   
                }
                input = Console.ReadLine();
            }
            if (input == "Stop")
            {
                sum += gols;
                if (gols > max)
                {
                    max = gols;
                    Console.WriteLine($"{gols}");
                }
            }
                    Console.WriteLine($"{max}");
                
            }
        }
    }
    
