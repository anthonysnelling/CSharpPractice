using System;

Console.WriteLine("Hello World!");
Console.WriteLine("A long Journey lies Ahead.");
Console.WriteLine("A first step starts off every journey.");
Console.WriteLine("If you keep going you will get far.");
Console.WriteLine("So what are you waiting for? Lets GO!");

Console.WriteLine("\nBread is ready");
Console.WriteLine("Who is the bread for?");
string name = Console.ReadLine();
Console.WriteLine($"Noted: {name} received bread.");


/* Comments in C# */
Console.WriteLine("\nWhat kind of thing are we talking about");
// describe the object we are talking about
string a = Console.ReadLine();
Console.WriteLine("How would you describe it? Big? Azure? Tattered");
// store a description for the give object
string b = Console.ReadLine();
// Two additional descriptions for this object
string c = "Doom";
string d = "3000";
Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");
