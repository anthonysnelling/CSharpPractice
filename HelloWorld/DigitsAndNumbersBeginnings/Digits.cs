using System;
    public class Digits
    {
        public static void Main(string[] args)
        {
            // you can yse underscores as a digit separator if needed.  
            int bigDigit = 1_000_000_000;
            Console.WriteLine($"Here is the big number: {bigDigit}");

            Console.WriteLine("You can use binary or hexadecimal literals by using 0b or 0x eg,");
            int binLiteral = 0b00001101;
            int hexCode = 0xFF00FF;
            Console.WriteLine("The code will be converted to int if you are using the int type though (or whatever valid data type you are using really)");
            Console.WriteLine($"binary literal: {binLiteral} and here is hexCode: {hexCode}");
           
            Console.WriteLine("\nAlthough chars are not a digit exactly you can use them to store characters, (hence the name)");
            Console.WriteLine("If you know the unicode number for a character you can use \\u");
            char aLetter = '\u0061'; 
            Console.WriteLine("\\u0061 would be the letter: " + aLetter);

            Console.WriteLine("\nWhen it comes to floating point numbers you have the data types float and double");
            Console.WriteLine("Float uses 4 bytes while double uses 8 bytes, then there is decimal which uses 16 bytes");
            Console.WriteLine("Decimal isnt as fast, but preserves significant digits, probably should only be used in cases " +
                              "where extreme mathematical precision is a requirement");
            Console.WriteLine("Floats have 7 digit precision, Doubles 15-16, Decimals have 28-29");

            Console.WriteLine(
                "\n When a number has a decimal point in it, becomes a double literal, it you append an 'f', a float" +
                " literal and if you append a 'm' (stand for money, which needs to be precise) ");
            Console.WriteLine("Float: 3.1456f \n" +
                              "Decimal: 3.1456m \n" +
                              "Double: 3.1456");
            
        }
    }
