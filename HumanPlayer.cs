using System;
namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {

        public override int Roll()
        {
            Console.Write("What number did your human player roll? ");
            string humanRoll = Console.ReadLine();
            int parsedRoll;
            int.TryParse(humanRoll, out parsedRoll);

            // Return a random number between 1 and DiceSize
            return parsedRoll;
        }

    }
}