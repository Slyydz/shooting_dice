using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        public List<string> Taunt { get; set; }

        public void shoutCreativeTaunt()
        {
            Taunt = new List<string> { "No way I lose.", "Come on just give up you dont have a shot.", "I am so going to win.", "Winner Winner, Chicken Dinner." };
            Console.Write("Choose a number between 1 and 4: ");
            int choice = Int32.Parse(Console.ReadLine()) - 1;
            Console.WriteLine(Taunt[choice]);
        }
        public override int Roll()
        {
            // Return a random number between 1 and DiceSize
            shoutCreativeTaunt();
            return new Random().Next(DiceSize) + 1;
        }
    }
}