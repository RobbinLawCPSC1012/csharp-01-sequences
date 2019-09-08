using System;

namespace _04_VariablesAndStringBuilding
{
    class VariablesAndStringBuilding
    {
        static void Main()
        {
            string name = "Lamp";
            double price = 4.50;
            double height = 15.1283;
            bool hasLightBulb = true;
            string desc =
                $"Name: {name} \nPrice: {price:C}" +
                $"\nHeight: {height:000.00} cm " +
                $"\nHas Light Bulb: {hasLightBulb}";
            Console.WriteLine(desc);

        }
    }
}
