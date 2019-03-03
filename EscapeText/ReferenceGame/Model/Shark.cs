// Shark class

using System;
using System.Collections.Generic;

namespace ReferenceGame
{
    public class Shark : Item
    {
        public Shark()
        {
            LongName = "Shark";
            CompactName = "shark";

            ItemActionMessages.Add("examine", "Dude looks hangry. Yikes.");
            ItemActionMessages.Add("use", "The shark refuses your advances and bites off your arm."); 
            //TODO: keep track of lost limbs
        }

        public override string Use(GarageRoom room)
        {
            if (BeenUsed)
                return $"Sorry, {LongName} has already been used.";
            else
            {
                BeenUsed = true;

                if (room.DoesItemExistInRoom("garagedooropener"))
                    return "You attempt to use the dead shark, but it bites off your fingers. Fool.";
                else
                {
                    BeenUsed = false;
                    return ItemActionMessages["use"];
                }
            }
        }

    }

}
