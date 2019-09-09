using System;

namespace _07_CircleCircumference
{
    class CircleCircumference
    {
        static void Main()
        {
            double myRadius;
            double myPi = Math.PI;
            double myCircumference;

            Console.Write("Enter the Radius as a double: ");
            myRadius = double.Parse(Console.ReadLine());

            myCircumference = 2.0 * myPi * myRadius;

            Console.WriteLine($"The Radius was {myRadius:n} and its Circumference is {myCircumference:n}");
        }
    }
}
