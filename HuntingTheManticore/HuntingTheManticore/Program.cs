using System;
using System.Security.Cryptography.X509Certificates;

namespace HuntingTheManticore
{
    class Program
    {
        private static int manticoreDistance, manticoreHealth = 10, cityHealth = 15;
        private static int cannonDamage = 1;
        private static int round = 1;
        private static int cannonAim;
        private static bool gameLoop = true;

        public static int getManticoreDist()
        {
            try
            {
                int distance = Int32.Parse(Console.ReadLine());

                if (distance < 0 || distance > 100)
                {
                    Console.WriteLine("You must choose a value greater than -1 and less than 101");
                    getManticoreDist();
                }

                return distance;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Value must be an -INTEGER- between 0 and 100\nTry Again...");
                getManticoreDist();
            }

            return 0;
        }

        public static int getCannonAim()
        {
            try
            {
                int distance = Int32.Parse(Console.ReadLine());

                if (distance < 0 || distance > 100)
                {
                    Console.WriteLine("You must choose a value greater than -1 and less than 101");
                    getCannonAim();
                }

                return distance;
            }
            catch (FormatException e)
            {
                Console.WriteLine("\nValue must be an -INTEGER- between 0 and 100\nTry Again...");
                getCannonAim();
            }

            return 0;
        }

        public static void GetStatus()
        {
            Console.WriteLine("STATUS: Round: {0}, City:{1}/15, Manticore:{2}/10", round, cityHealth, manticoreHealth);
        }

        public static void player2Turn()
        {
            cannonDamage = 1;
            if (round % 3 == 0 && round % 5 == 0)
            {
                cannonDamage = 10;
            }
            else if (round % 3 == 0 || round % 5 == 0)
            {
                cannonDamage = 3;
            }

            Console.WriteLine("The cannon is expected to deal {0} damage this round.", cannonDamage);
            Console.Write("Enter The Desired cannon range: ");
            cannonAim = getCannonAim();
            Console.Write("\n");

            if (cannonAim > manticoreDistance)
            {
                cityHealth -= 1;
                round++;
                Console.WriteLine("That round OVERSHOT the target.");
            }
            else if (cannonAim < manticoreDistance)
            {
                cityHealth -= 1;
                round++;
                Console.WriteLine("That round FELL SHORT of the target.");
            }
            else if (cannonAim == manticoreDistance)
            {
                manticoreHealth -= cannonDamage;
                cityHealth -= 1;
                round++;
                Console.WriteLine("That round HIT the target!!!");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(
                "The Uncoded one's airship The Manticore, has begun an all-out attack on the city of consolas. \n" +
                "Destroy it or the city will fall! Player one will place the distance of the Manticore in secret.\n" +
                "Player two will control the city and stop it by guessing between 0 and 100 and being told if they are too far\n" +
                "or too short.\n");

            Console.WriteLine("Player 1, how far away will you Station The Manticore? (0 - 100)");

            // Get input and establish how far manticore is from city from 0 to 100.
            manticoreDistance = getManticoreDist();

            Console.Clear();
            // second player repeatedly attempts to destroy the manticore until city is destroyed.
            Console.WriteLine("Player 2 it is your turn, aim the cannon, find and destroy The Manticore!");
            while (cityHealth > 0 || manticoreHealth > 0)
            {
                GetStatus();
                player2Turn();
            }

            if (manticoreHealth <= 0)
            {
                Console.WriteLine("The Manticore had been destroyed! The city has been saved!");
            }else if (cityHealth == 0)
            {
              Console.WriteLine("You failed... The city has fallen, The Manticore is victorious...");  
            } 

        }
    }
}