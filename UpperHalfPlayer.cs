using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player whose role will always be in the upper half of their possible rolls
    public class UpperHalfPlayer : Player
    {
        // OVERRIDE ROLL METHOD HAVING IT ROLL A RANDOM NUMBER FOR HALF THE RESULT, THEN ADDING HALF THE DIE VALUE AUTOMATICALLY
        public override int Roll()
        {
            // Return a random number between 1 and DiceSize
            return new Random().Next(DiceSize / 2) + (DiceSize / 2);
        }
    }
}
