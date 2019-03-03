// Item class

using System;
using System.Collections.Generic;

namespace ReferenceGame
{
    public class Honeybear : Item
    {
        public Honeybear()
        {
            LongName = "Honeybear";
            CompactName = "honeybear";

            ItemActionMessages.Add("examine", "Looks like a bottle of honey shaped like a bear.");
            ItemActionMessages.Add("use", "You pick up the honeybear bottle and squeeze out a glistening trail of lavender honey into your mouth. However, your aim is not what it used to be and you end up with honey all over your face and neck. A trail of ants marches out from a crack in the wall and starts lapping up the honey!");
            
        }


        public override string Use(GarageRoom room)
        {
            if (BeenUsed)
                return $"Sorry, {LongName} has already been used.";
            else
            {
                BeenUsed = true;
                if (room.RoomContents.Find(x => x.LongName == "Blanket").BeenUsed)
                    return ItemActionMessages["use"] + "\nThe echidna scampers to slurp up the ants. The happy echidna is now your buddy.";
                else
                    return ItemActionMessages["use"];
            }
        }

    }

}
