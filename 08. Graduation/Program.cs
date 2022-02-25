using System;

namespace _08._Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            double averageMark = 0;
            double averageMarkForTwelveYears = 0;
            string markText = "";
            for (int i = 1; i <= 12; i++)
            {
                double mark = double.Parse(Console.ReadLine());
                if(mark >= 4)
                {
                    averageMark += mark;
                    averageMarkForTwelveYears = averageMark / 12;
                    markText=  studentName + " graduated. Average grade: " + Math.Round(averageMarkForTwelveYears, 2);              
                }
                else
                {

                    averageMark = mark++; 
                        if (averageMark <= 4)
                        {
                            Console.WriteLine(studentName + " has been excluded at " + i + " grade");
                            return;
                        }                   
                }           
            }
            Console.WriteLine(markText);
        }
    }
}
