using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

namespace Enums
{
    class Program
    {
        // An enumeration is a type whose choices are one of a small list of possible options. Enumerations
        // are good gor a small set  of choices, that you can make an exhaustive list for. 
        enum Season
        {
            Winter,
            Spring,
            Summer,
            Fall
        }
        // Now we can use a Season as a type!

        enum Chest
        {
            Opened,
            Locked,
            Closed
        }

        enum Actions
        {
            Open,
            Lock,
            Unlock,
            Close
        }

        static Chest _chestStatus = Chest.Locked;
        static Actions _attemptedAction = Actions.Close;

        private static String _input = "";

        static Actions GetOption()
        {
            _input = Console.ReadLine();
            switch (_input)
            {
                case "close":
                    _attemptedAction = Actions.Close;
                    break;
                case "unlock":
                    _attemptedAction = Actions.Unlock;
                    break;
                case "lock":
                    _attemptedAction = Actions.Lock;
                    break;
                case "open":
                    _attemptedAction = Actions.Open;
                    break;
                default:
                    Console.WriteLine("You have to type a correct option");
                    break;
            }

            return _attemptedAction;
        }

        static Chest ChestState()
        {
            if (_chestStatus == Chest.Closed && _attemptedAction == Actions.Open)
            {
                _chestStatus = Chest.Opened;
                Console.WriteLine("You opened the chest!");
            }

            else if (_chestStatus == Chest.Opened && _attemptedAction == Actions.Close)
            {
                _chestStatus = Chest.Closed;
                Console.WriteLine("You Closed the Chest!");
            }

            else if (_chestStatus == Chest.Locked && _attemptedAction == Actions.Unlock)
            {
                _chestStatus = Chest.Closed;
                Console.WriteLine("You Unlocked the Chest!");
            }

            else if (_chestStatus == Chest.Closed && _attemptedAction == Actions.Lock)
            {
                _chestStatus = Chest.Locked;
                Console.WriteLine("You Locked the Chest!");
            }
            else
            {
                Console.WriteLine("You can't do that. try again");
            }

            return _chestStatus;
        }

        static void Main(string[] args)
        {
            String greeting;
            Season current = Season.Summer;
            Console.WriteLine(current); // Prints summer

            // You can also  compare enums like ints
            // this is a ternary operator it shortens if and elses
            greeting = (current == Season.Summer) ? "Happy Solstice" : "Happy Equinox";
            Console.WriteLine(greeting);

            Console.WriteLine("You see a locked chest before you. What would you like to do?");
            while (true)
            {
                GetOption();
                ChestState();
                Console.WriteLine($"The Chest is {_chestStatus}. What would you like to do?");
            }
        }
    }
}