using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        List<string> taunts = new List<string>
            {
                "You are proof that God has a sense of humor.",
                "You have delusions of adequecy",
                "I like the way you try",
                "I like your approach, now let's see your departure",
                "It's impossible to underestimate you"
            };


        public override void Play(Player other)
        {

            base.Play(other);
        }


    }
}