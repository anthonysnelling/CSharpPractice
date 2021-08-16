using System;

namespace ModulusOrRemaider
{
    class Program
    {
        private static int num1;
        private static int num2;
        private static int quotient;
        private static int remainder;

        static void Main(string[] args)
        {
            Console.WriteLine("This program just tells you the quotient and remainder of a division operation.");
            Console.WriteLine("What is the first number you want to divide?");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is the second number you want to divide by?");
            num2 = Int32.Parse(Console.ReadLine());
            quotient = num1 / num2;
            remainder = num1 % num2;
            Console.WriteLine(num1.ToString() + " / " + num2.ToString() + $" has a quotient of: {quotient} and a remainder of: {remainder}");
        }
    }
}