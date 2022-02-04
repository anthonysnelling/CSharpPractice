using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Tuples
{
    class Program
    {
        enum Tiletype
        {
            Grass,
            Water,
            Rock
        }

        static void Main(string[] args)
        {
            // tuples are a composite type of multiple elements
            // you can form tuples with the use of parentheses
            (string, int, int) score = ("Tony", 90000, 1);

            // you can use var to help out with the typing
            var score2 = ("Abby", 140000, 2);

            // you can access the items individually like so
            Console.WriteLine($"Name:{score.Item1}, Level:{score.Item3}, Score:{score.Item2}");
            Console.WriteLine($"Name:{score2.Item1}, Level:{score2.Item3}, Score:{score2.Item2}");

            //If you don't use var you can name the elements things other than item1, item2, etc.
            (string name, int model, string color) car = ("Pontiac G6", 2009, "gold");
            Console.WriteLine($"\nI own a {car.color} {car.name} from {car.model}");
            // there is a way to do it with var, but the types are inferred and the syntax is different
            var car2 = (name: "Chevy Cavalier", model: 2005, color: "silver");
            Console.WriteLine($"My last car was a {car2.color} {car2.model} {car2.name}");

            //vars can be useful for coding quick and concise, but you can't use vars as parameters
            // be careful if you need to pass a tuple as a parameter or return it in a funct ion

            // you can even use a tuple and an enum together
            var tile = (Row: 2, Column: 4, Type: Tiletype.Grass);
            
            // You can make a tuple array
            (string name, int points, int level)[] CreateHighScores()
            {
                return new (string, int, int)[3]
                {
                    ("Tom", 12420, 15),
                    ("Alan", 8453, 9),
                    ("Carol", 900, 3),
                };
            }
        }
    }
}