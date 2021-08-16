using System;

namespace AreaOfATriangle
{
    class Program
    {
        private static float area, width, height;
        private const int DivByTwo = 2;
        static void Main(string[] args)
        {
            Console.WriteLine("This program finds the area of a triangle!");
            Console.WriteLine("What is the width of the base of the triangle?");
            width = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is the height of the triangle?");
           height  = Int32.Parse(Console.ReadLine());
           area = (height * width) / DivByTwo;
           Console.WriteLine($"The area of the triangle is: {area}");
        }
    }
}