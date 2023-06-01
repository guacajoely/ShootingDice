using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        // OVERRIDE ROLL METHOD HAVING IT PROMT USER TO ENTER THE AMOUNT
        // GRAB IT WITH READLINE AND PARSE IT INTO AN INTEGER (FAILED PARSE RETURNS 0 FOR ROLL)
        public override int Roll()
        {

            Console.WriteLine($"What number did {Name} (human player) roll?");
            Console.Write($"Enter a number between 1 and {DiceSize}: ");
            string humanRoll = Console.ReadLine();
            int parsedRoll;
            int.TryParse(humanRoll, out parsedRoll);

            if(parsedRoll > 0 && parsedRoll <= DiceSize)
            {
                // RETURN PARSED ROLL IF BETWEEN 0 AND MAX DICE SIZE
                return parsedRoll;
            }

            // RETURN 0 IF RECIEVE INVALID RESPONSE FROM USER AND INFORM THEM
            else
            {
                Console.WriteLine($"Invalid response. {Name}'s roll was set to 0.");
                return 0;
            }

        }
    }
}
