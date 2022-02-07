using System;
using System.Data.SqlTypes;

namespace UsingClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            string fletchling, arrowHead;
            float shaft;

            Console.WriteLine("Welcome to the Arrow shop!");
            Console.WriteLine("What kind of Arrow head do you want? Obsidian - 5g, Wood - 3g, or Steel - 10g?");
            arrowHead = Console.ReadLine();

            Arrow.ArrowHead arrowHeadType = Arrow.ArrowHead.Steel;

            switch (arrowHead)
            {
                case "obsidian":
                    arrowHeadType = Arrow.ArrowHead.Obsidian;
                    break;
                case "wood":
                    arrowHeadType = Arrow.ArrowHead.Wood;
                    break;
                case "steel":
                    arrowHeadType = Arrow.ArrowHead.Steel;
                    break;
            }
            
            Console.WriteLine(
                "What kind of fletchling do you want? Plastic - 10g, Goose Feather - 3g, or Turkey Feather - 5g?");
            fletchling = Console.ReadLine();
            
            Arrow.Fletchling fletchlingType = Arrow.Fletchling.Plastic;
            switch (fletchling)
            {
               case "plastic" :
                   fletchlingType = Arrow.Fletchling.Plastic;
                   break;
               case "turkey feather":
                   fletchlingType = Arrow.Fletchling.TurkeyFeather;
                   break;
               case "goose feather":
                   fletchlingType = Arrow.Fletchling.GooseFeather;
                   break;
            }

            Console.WriteLine(
                "What do you want the length of the arrow shaft to be in centimeters, (number between 60 and 100)?");
            shaft = float.Parse(Console.ReadLine());
            
            Arrow arrow = new Arrow(shaft, fletchlingType, arrowHeadType);
            Console.WriteLine($"You chose a {arrow.arrowHead} arrowHead, a {arrow.fletchling} fletchling, and a {arrow.shaft}cm arrow shaft");
            Console.WriteLine($"it costs {arrow.GetCost()} gold");
        }
    }

    class Arrow
    {
        public enum ArrowHead
        {
            Steel = 10,
            Wood = 3,
            Obsidian = 5
        }

        public enum Fletchling
        {
            Plastic = 10,
            TurkeyFeather = 5,
            GooseFeather = 3
        }

        public float shaft = 0.00f;
        public ArrowHead arrowHead;
        public Fletchling fletchling;

        public Arrow(float shaft, Fletchling fletchling, ArrowHead arrowHead)
        {
            this.shaft = shaft;
            this.fletchling = fletchling;
            this.arrowHead = arrowHead;
        }

        /// <summary>
        /// finds the total cost of an arrow object
        /// </summary>
        /// <returns></returns>
        public float GetCost() => (shaft * 0.05f) + (float)arrowHead + (float)fletchling;
    }
}