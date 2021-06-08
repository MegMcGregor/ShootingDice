using System;

namespace ShootingDice
{
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            Console.WriteLine("enter a number between 1-6 to roll");
            string HumanRoll = Console.ReadLine();

            int myRoll = int.Parse(HumanRoll);

            return myRoll;
        }
    }
}