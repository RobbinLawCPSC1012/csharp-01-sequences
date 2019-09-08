using System;

namespace _06_ReadLineAndParse
{
    class ReadLineAndParse
    {
        static void Main()
        {
            string name;
            int age;
            double annualPay;
            
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your annual salary:");
            annualPay = double.Parse(Console.ReadLine());

            Console.WriteLine($"My name is {name}, my age is {age} " +
                              $"and I hope to earn {annualPay:c} per year.");
        }
    }
}
