using System;

namespace _05_Math
{
    class Math
    {
        static void Main()
        {
            int myInt1 = 8;
            int myInt2 = 5;
            double myDouble1 = 8.0;
            double myDouble2 = 5.0;
            double myDouble3 = 6.0;
            int myIntAnswer;
            double myDoubleAnswer;

            myIntAnswer = myInt1 / myInt2; //only gives the whole part of division
            Console.WriteLine($"The answer is: {myIntAnswer}");
            myIntAnswer = myInt2 / myInt1; //only gives the whole part of division
            Console.WriteLine($"The answer is: {myIntAnswer}");
            myIntAnswer = myInt1 % myInt2; //gives the remainder of division
            Console.WriteLine($"The remainder is: {myIntAnswer}");

            myIntAnswer = myInt1 / (int)myDouble2; //only gives the whole part of division as the double is cast to an int
            Console.WriteLine($"The answer is: {myIntAnswer}");
            myIntAnswer = (int)myDouble2 / myInt1; //only gives the whole part of division as the double is cast to an int
            Console.WriteLine($"The answer is: {myIntAnswer}");
            myIntAnswer = (int)myDouble1 % myInt2; //gives the remainder of division as the double is cast to an int
            Console.WriteLine($"The remainder is: {myIntAnswer}");

            myDoubleAnswer = myDouble1 / myDouble2; //only gives the whole part of division as the double is cast to an int
            Console.WriteLine($"The answer is: {myDoubleAnswer}");
            myDoubleAnswer = myDouble2 / myDouble1; //only gives the whole part of division as the double is cast to an int
            Console.WriteLine($"The answer is: {myDoubleAnswer}");

            myDoubleAnswer = myDouble1 + myDouble2 * myDouble3 / myDouble1;  
            //multiplication and Division precede Add and Substract
            //when at the same level left to right so here Mult first, then Divide, then Add
            Console.WriteLine($"The answer is:  {myDoubleAnswer:n3}");

            myDoubleAnswer = (myDouble1 + myDouble2) * myDouble3 / myDouble1;
            //multiplication and Division precede Add and Substract
            //when at the same level left to right so here Mult first, then Divide, then Add
            Console.WriteLine($"The answer is:  {myDoubleAnswer:n3}");
        }
    }
}
