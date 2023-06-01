using System;
using System.Collections.Generic;
using System.Linq;
namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public List<string> Taunts { get; } = new List<string>(){"Taunt 1", "Taunt 2", "Taunt 3", "Taunt 4", "Taunt 5", "Taunt 6", "Taunt 7", "Taunt 8", "Taunt 9", "Taunt 10" };
        int TauntSelection = new Random().Next(0, 9);

        public override int Roll()
        {
            // Return a random number between 1 and DiceSize
            Console.WriteLine(Taunts[TauntSelection]);
            return new Random().Next(DiceSize) + 1;


        }
    }
}