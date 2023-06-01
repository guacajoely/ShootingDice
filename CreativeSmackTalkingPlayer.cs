using System;
using System.Collections.Generic;
using System.Linq;
namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        // DECLARE LIST OF TAUNTS
        public List<string> Taunts { get; } = new List<string>(){"Taunt 1", "Taunt 2", "Taunt 3", "Taunt 4", "Taunt 5", "Taunt 6", "Taunt 7", "Taunt 8", "Taunt 9", "Taunt 10" };

        //DECLARE NEW RANDOM TO CALL RANDOM TAUNT WITH INDEX
        int TauntSelection = new Random().Next(0, 9);

        // OVERRIDE ROLL METHOD ADDING A WRITELINE CALLING THE TAUNT FROM THE LIST BY ITS INDEX
        public override int Roll()
        {
            // Return a random number between 1 and DiceSize
            Console.WriteLine(Taunts[TauntSelection]);
            return base.Roll();
        }
    }
}