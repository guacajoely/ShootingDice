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
            // Return a random number between halfMax and DiceSize
            int halfMax = DiceSize/2;
            return new Random().Next(halfMax) + halfMax;

            //COULD ALSO REFACTOR TO SELECT RANDOM IN RANGE BETWEEN HALFMAX AND MAX 
            // return new Random().Next((halfMax), DiceSize);
        }
    }
}
