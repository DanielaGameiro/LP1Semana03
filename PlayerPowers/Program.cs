using System;

namespace PlayerPowers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user for a number of players
            Console.Write("Number of player: ");
            int n = int.Parse(Console.ReadLine());

            // Create array for the player powers
            Powers[] playerPowers = new Powers[n];

            // Ask the powers of each player one by one 
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nPlayer {i + 1}");

                Console.WriteLine($"Fly power? (y/n): ");
                if (Console.ReadLine() == "y")
                    playerPowers[i] |= Powers.Fly;

                Console.WriteLine($"XRay Vision power? (y/n): ");
                if (Console.ReadLine() == "y")
                    playerPowers[i] |= Powers.XRayVision;

                Console.WriteLine($"Super Strength power? (y/n): ");
                if (Console.ReadLine() == "y")
                    playerPowers[i] |= Powers.SuperStrength;
            }

            // Show it 
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nPlayer {i + 1}: ");
                Console.WriteLine(playerPowers[i]);

                // Extra condition
                if ((playerPowers[i] & (Powers.Fly | Powers.SuperStrength)) == (Powers.Fly | Powers.SuperStrength))
                    Console.Write("Flying radiation!");

                Console.WriteLine();
            }
        }
    }
}
