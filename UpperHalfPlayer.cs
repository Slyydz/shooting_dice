using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player whose role will always be in the upper half of their possible rolls
    public class UpperHalfPlayer : Player
    {
        public override int Roll()

        {
            int randRoll = 0;
            while (randRoll < DiceSize / 2)
            {
                randRoll = new Random().Next(DiceSize) + 1;
            }
            // Return a random number between 1 and DiceSize
            return randRoll;
        }
    }
}