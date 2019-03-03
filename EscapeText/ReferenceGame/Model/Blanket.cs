
using System;
using System.Collections.Generic;

namespace ReferenceGame
{
    public class Blanket : Item
    {
        public Blanket()
        {
            LongName = "Blanket";
            CompactName = "blanket";

            ItemActionMessages.Add("examine", "Looks like one of those heavy furniture blankets movers use.");
            ItemActionMessages.Add("use", "You wrap the heavy blanket around your shoulders. Hark! An adorable echidna was hiding under the blanket!");
        }
        public override string Use(GarageRoom room)
        {
            if (BeenUsed)
                return $"Sorry, {LongName} has already been used.";
            else
            {
                BeenUsed = true;

                Item echidna = room.GetHiddenRoomContentsByName("echidna");
                room.RoomContents.Add(echidna);
                room.RoomContentsAsStringList.Add("Echidna");

                if (room.WaterLevel == 0)
                {
                    room.CurrentScene = room.GarageScenes.ScenesDictionary["Water00_EchidnaNotButton"];
                }
                else if (room.WaterLevel > 0)
                {
                    string scn = "Water0" + room.WaterLevel + "_EchidnaAndButton";
                    room.CurrentScene = room.GarageScenes.ScenesDictionary[scn];
                }

                if (room.GetRoomContentsByName("honeybear").BeenUsed)
                {
                    return ItemActionMessages["use"] + "\nThe echidna scampers to slurp up the ants. The happy echidna is now your buddy.";
                }
                else
                    return ItemActionMessages["use"];
            }

        }

    }

}
