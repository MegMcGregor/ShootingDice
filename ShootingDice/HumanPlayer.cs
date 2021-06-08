using System;

namespace ShootingDice
{
    public class HumanPlayer : Player
    {
        public override void Play(Player other)
        {
            Console.WriteLine("enter a number between 1-6 to roll");
            string HumanRoll = Console.ReadLine();

            int otherRoll = int.Parse(HumanRoll);
            int myRoll = Roll();

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
            {
                Console.WriteLine($"{other.Name} Wins!");
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }

        }
    }
}