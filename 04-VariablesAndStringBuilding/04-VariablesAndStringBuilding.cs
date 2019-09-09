using System;

namespace _04_VariablesAndStringBuilding
{
    class VariablesAndStringBuilding
    {
        static void Main()
        {
            string name = "Lamp";
            int howMany = 34;
            double price = 4.52;
            double height = 1234.1283;
            bool hasLightBulb = true;

            // when a string begins with $ then whenever there is an {} inside is a variable contents,justify format:presentation format
            Console.WriteLine($"howMany is [{howMany,-15:d2}] lamps"); //left justified, decimal whole number, 2 digits
            Console.WriteLine($"howMany is [{howMany,15:d3}] lamps");  //right justified, decimal whole number, 3 digits
            Console.WriteLine($"howMany is [{howMany,15:n3}] lamps");  //right justified, numeric 3 decimals
            Console.WriteLine($"height is [{height,-15:n2}] cm");  //left justified, numeric 2 decimals
            Console.WriteLine($"height is [{height,15:n3}] cm");  //right justified, numeric 3 decimals
            Console.WriteLine($"price is [{price,-10:c2}]");  //left justified, currency 2 decimals
            Console.WriteLine($"price is [{price,10:c3}]");  //right justified, currency 3 decimals
            Console.WriteLine($"price is [{price,10:n1}]");  //right justified, numeric 1 decimals
            // string building
            string desc =
                $"\nName: {name} \nPrice: {price:c}" +
                $"\nHow Many: {howMany:d}" +
                $"\nHeight: {height:n} cm " +
                $"\nHas Light Bulb: {hasLightBulb}";
            Console.WriteLine(desc);

            //https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/string-interpolation
        }
    }
}
