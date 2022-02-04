using System;
using System.Linq;

namespace EnumAndTupleSoup
{
    class Program
    {
        enum FoodType
        {
            Soup,
            Stew,
            Gumbo
        }

        enum MainIngredient
        {
            Mushrooms,
            Chickens,
            Carrots,
            Potatoes
        }

        enum Seasoning
        {
            Spicy,
            Salty,
            Sweet
        }

        private static FoodType GetFoodType(string input)
        {
            switch (input)
            {
                case "soup":
                    return FoodType.Soup;
                case "stew":
                    return FoodType.Stew;
                case "gumbo":
                    return FoodType.Gumbo;
                default:
                    return FoodType.Gumbo;
            }
        }

        private static MainIngredient GetMainIngredient(string input)
        {
            switch (input)
            {
                case "mushrooms":
                    return MainIngredient.Mushrooms;
                case "chickens":
                    return MainIngredient.Chickens;
                case "carrots":
                    return MainIngredient.Carrots;
                case "potatoes":
                    return MainIngredient.Potatoes;
                default:
                    return MainIngredient.Mushrooms;
            }
        }

        private static Seasoning GetSeasoning(string input)
        {
            switch (input)
            {
                case "salty":
                    return  Seasoning.Salty;
                case "sweet":
                    return Seasoning.Sweet;
                case "spicy":
                    return Seasoning.Spicy;
                default:
                    return Seasoning.Salty;
            }
        }

        private static (FoodType, MainIngredient, Seasoning) MakeASoup()
        {
            (FoodType, MainIngredient, Seasoning) soup;
            Console.WriteLine("Lets start with the type: soup, stew, or gumbo?");
            FoodType soupType;

            string input = "";
            bool validationCheck = false;
            while (!validationCheck)
            {
                input = Console.ReadLine();
                validationCheck = StringValidation(input);
            }

            soupType = GetFoodType(input);


            Console.WriteLine("Alright choose a Main ingredient: mushrooms, chickens, carrots, or potatoes");
            MainIngredient mainIngredient;

            input = "";
            validationCheck = false;
            while (!validationCheck)
            {
                input = Console.ReadLine();
                validationCheck = StringValidation(input);
            }
            mainIngredient = GetMainIngredient(input);


            Console.WriteLine("Now Choose the Seasoning: spicy, salty, sweet");
            Seasoning seasoning;

            input = "";
            validationCheck = false;
            while (!validationCheck)
            {
                input = Console.ReadLine();
                validationCheck = StringValidation(input);
            }
            seasoning = GetSeasoning(input);

            soup = (soupType, mainIngredient, seasoning);
            return soup;
        }

        private static bool StringValidation(string input)
        {
            switch (input)
            {
                case "spicy":
                    return true;
                case "salty":
                    return true;
                case "sweet":
                    return true;
                case "mushrooms":
                    return true;
                case "chickens":
                    return true;
                case "carrots":
                    return true;
                case "potatoes":
                    return true;
                case "soup":
                    return true;
                case "stew":
                    return true;
                case "gumbo":
                    return true;
                default:
                    Console.WriteLine("Incorrect type, please try again.");
                    return false;
            }
        }

        static void Main(string[] args)
        {
            var foodWeHaveMade = new (FoodType typeOfFood, MainIngredient mainIngredient, Seasoning seasoning) [3];
            Console.WriteLine("Greetings we will make threes soups!");

            Console.WriteLine("Here is the first pot!");
            foodWeHaveMade[0] = (MakeASoup());

            Console.WriteLine("\nTime for pot two!");
            foodWeHaveMade[1] = (MakeASoup());

            Console.WriteLine("\nNow for the final pot!");
            foodWeHaveMade[2] = (MakeASoup());

            Console.WriteLine("Here are the soups we have made!");
            Console.WriteLine(
                $"First soup: {foodWeHaveMade[0].seasoning} {foodWeHaveMade[0].mainIngredient} {foodWeHaveMade[0].typeOfFood}");
            Console.WriteLine(
                $"Second soup: {foodWeHaveMade[1].seasoning} {foodWeHaveMade[1].mainIngredient} {foodWeHaveMade[1].typeOfFood}");
            Console.WriteLine(
                $"Third soup: {foodWeHaveMade[2].seasoning} {foodWeHaveMade[2].mainIngredient} {foodWeHaveMade[2].typeOfFood}");
        }
    }
}