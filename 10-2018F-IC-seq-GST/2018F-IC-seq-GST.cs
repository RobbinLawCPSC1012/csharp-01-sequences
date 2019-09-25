using System;

namespace _10_2018InClass01
{
    class InClass01
    {
        static void Main()
        {
            // Declare variables that are Constants
            const double provTaxRate = 0.06;
            const double fedTaxRate = 0.05;

            // Inputs
            double itemPrice;
            int numItems;

            // Results
            double beforeTax;
            double totalProvTax;
            double totalFedTax;
            double totalTax;
            double totalSale;

            Console.WriteLine("Enter the item price as a double: ");
            itemPrice = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Number of Items as an integer: ");
            numItems = int.Parse(Console.ReadLine());

            beforeTax = itemPrice * numItems;
            Console.WriteLine($"Purchase Total (before Tax): {beforeTax:C}");

            // Calculate Tax
            totalProvTax = beforeTax * provTaxRate;
            Console.WriteLine($"Total Provincial Tax: {totalProvTax:C}");

            totalFedTax = beforeTax * fedTaxRate;
            Console.WriteLine($"Total Federal Tax: {totalFedTax:C}");

            totalTax = totalProvTax + totalFedTax;
            Console.WriteLine($"Total Tax Amount: {totalTax:C}");

            totalSale = beforeTax + totalTax;
            Console.WriteLine($"Total Sale price: {totalSale:C}");
        }
    }
}
