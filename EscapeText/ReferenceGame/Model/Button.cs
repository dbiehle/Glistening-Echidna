
using System;
using System.Collections.Generic;

namespace ReferenceGame
{
    public class Button : Item
    {
        public Button()
        {
            LongName = "Button";
            CompactName = "button";

            ItemActionMessages.Add("examine", "It's a big beautiful button");
            ItemActionMessages.Add("use", "You press the button and hear a click followed by a whir, a thunk, and what sounds like water flowing through pipes.");
        }

        public override string Use(GarageRoom room)
        {
            if (BeenUsed)
                return $"You try to press the BUTTON again, but the water level keeps rising.";
            else
            {
                BeenUsed = true;

                if(!room.DoesItemExistInRoom("echidna"))
                {
                    room.CurrentScene = room.GarageScenes.ScenesDictionary["Water00_ButtonNoEchidna"];
                }
                else
                {
                    room.CurrentScene = room.GarageScenes.ScenesDictionary["Water00_EchidnaAndButton"];
                }
                return ItemActionMessages["use"];
            }
        }

    }

}
