using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        // DECLARE TAUNT
        public string Taunt { get; } = "SCARED MONEY DONT MAKE MONEY";

        // OVERRIDE ROLL METHOD ADDING A WRITELINE OF THE TAUNT
        public override int Roll()
        {
            // Return a random number between 1 and DiceSize
            Console.WriteLine(Taunt);
            return base.Roll();
        }
    }
}
