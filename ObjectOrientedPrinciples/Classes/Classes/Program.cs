using System;
using System.Globalization;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // making a new instance of a classs
            Score best = new Score();
            best.name = "Armando";
            best.points = 12420;
            best.level = 15;
            if (best.EarnedStar())
            {
                Console.WriteLine("You earned a star!");
            }

            //You can create multiple instances of a classes
            Score b = new Score();
            b.name = "Thomas";
            b.points = 8900;
            b.level = 8;
            if (b.EarnedStar())
            {
                Console.WriteLine($"{b.name} You earned a star!");
            }

            // creating a class object with default values from the initializer
            Console.WriteLine("\nOur default object");
            Score defaulty = new Score();
            Console.WriteLine(defaulty.name);
            Console.WriteLine(defaulty.level);
            Console.WriteLine(defaulty.points);

            //You can also create an instance with a default constructor and pass it parameters to shorten this
            Score constructed = new Score("Bigby", 670000, 42);
            Console.WriteLine($"{constructed.name}, {constructed.points}, {constructed.level}");
        }
    }

    // You can create multiple classes in the same file
    // Classes can help provide encapsulation - Combining data and the operation of that data, into a well defined unit
    class Score
    {
        public string name;
        public int points;
        public int level;

        // You can add a constructor method to initialize a class instance with certain
        // default attributes. 
        public Score()
        {
            name = "Unknown";
            points = 0;
            level = 1;
        }

        public Score(string name, int points, int level)
        {
            this.name = name;
            this.points = points;
            this.level = level;
        }

        public bool EarnedStar() => (points / level) > 1000;
    }
}