using System;

namespace _03_Variables
{
    class Variables
    {
        static void Main()
        {
            string myString = "Robbin";
            int myInt = 15;
            double myDouble = 6.66;
            bool myBool = true;
            Console.WriteLine(myString + " " + myInt + " " + myDouble + " " + myBool);

            var foo = "Apple";
            var bar = 15;
            Console.WriteLine(foo + " " + bar);
        }
    }
}
