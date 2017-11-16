using System;

namespace HandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main method demonstrates the use of variables, operators, expressions, and statements".
            
            int x = 3;
            int y = 4;

            int sum = (x + y);
            Console.WriteLine("Sum of " + x + " and " + y + " is: " + sum);
            Console.WriteLine("Are the values of sum and 7 equal? " + (sum == 7 ? "True" : "False"));
            
            string text1 = "Hello";
            string text2 = "World";

            string message = (text1 + " " + text2);

            Console.WriteLine("Message: " + message);
            Console.WriteLine("Press any key ...");
        }
    }
}
