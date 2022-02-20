using System;

namespace Properties
{
    class Program
    {
        public class Rectangle
        {
            private float _width;
            private float _height;

            // our constructor for the class
            public Rectangle(float width, float height)
            {
                _width = width;
                _height = height;
            }

           // Using properties, we can make getters and setters for different parts way more concisely
           // using the get and set keywords
            public float Width
            {
                get => _width;
                set => _width = value;
            }
            
            //another property
            //SIDE NOTE: getters and setters can be made private as well!
            public float Height
            {
                get => _height;
                set => _height = value;
            }

            // we can also use anonymous and lambda functions for simple expressions
            public float Area => _width * _height;
        }
        
        public class Player
        {
            private string _name;
           
            //sometimes you need to make a very basic property
            // C# has a concise syntax for that below. called an auto-implemented property
            // or auto property
            public string Name { get; set; }
            
            //Sometimes you will want to initialize a field to a value, you can do so like below.
            // public string Name { get; set; } = "Player";

            // Here we have an Immutable property, it has no setter 
            // so it cannot be changed after creation. good for objects you want to be 
            // concrete after creation and don't want to change.
            public string GamerTag { get; } = "BigGamez0r";

            // constructor
            public Player(string name ,string gamerTag)
            {
                Name = name;
                GamerTag = gamerTag;
            }
            
            // You can make fields immutable as well using the 'readonly' keyword
            private readonly string idNum = "123";
            // vvvv this wouldn't work
            // idNum = "234";
            // The difference from const is that const is a variable thats consistent across the program and never changes
            // a readonly can be assigned when it is declared or in a constructor if the same class
            
        }
        
        public class Circle
        {
            public float X { get; set; } = 0;
            // The init accessor is like set but limited and be used with Object initializer syntax
            public float Y { get; init; } = 0;
            public float Radius { get; set; } = 0;

        }

        static void Main(string[] args)
        {
            //With our properties class now the outside world has field like access to our class
           // properties allow us to use clean simple syntax and keep information hiding and abstraction. 
            
            //We create a 2 by 3 rectangle
            Rectangle r = new Rectangle(2, 3);
            // We can easily change the Rectangles width as if it were a field.
            r.Width = 5;
            Console.WriteLine($"A {r.Width}x{r.Height} rectangle has an area of {r.Area}.");

            //our class with auto-properties
            Player p = new Player("Yorrick", "BigGamez0r");
            // vvvv this will not work because the property is immutable, we have no setter
            // p.GamerTag = "Yo";
           Console.WriteLine($"{p.Name}, {p.GamerTag}");

           //Using Object initializer syntax we can initialize an object after it is created.
           // NOTE: this can only be used with properties that have a setter
           // this syntax adjusts the Object after construction, so you are changing an object after its made.
           Circle circle = new Circle() { Radius = 3, X = -4 };
           Console.WriteLine($" Circle Radius = {circle.Radius}, Circle x pos:{circle.X}, Circle Y pos: {circle.Y}");
        }
    }
}