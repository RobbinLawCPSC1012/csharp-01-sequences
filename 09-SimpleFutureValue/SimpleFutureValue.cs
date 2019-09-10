using System;
// this program is written assuming that interest is compounded monthly or 12 times per year
namespace _09_SimpleFutureValue
{
    class SimpleFutureValue
    {
        static void Main()
        {
            Console.WriteLine("Enter Investment Amount:");
            double investAmt = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter annual interest rate in percentage:");
            double interestRate = double.Parse(Console.ReadLine());
            double monthlyInterest = interestRate / 100 / 12;

            Console.WriteLine("Enter Number of years:");
            int numYears = int.Parse(Console.ReadLine());

            double futureVal = investAmt * Math.Pow(1 + monthlyInterest, numYears * 12);

            Console.WriteLine($"Future Value is {futureVal:C}");
        }
    }
}
