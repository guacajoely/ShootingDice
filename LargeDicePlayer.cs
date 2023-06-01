namespace ShootingDice
{
    // A Player who brings a large die to the game
    public class LargeDicePlayer : Player
    {
        // ADJUST DICESIZE IN CONSTRUCTOR FUNCTION
        public LargeDicePlayer()
        {
            DiceSize = 20;
        }
    }
}