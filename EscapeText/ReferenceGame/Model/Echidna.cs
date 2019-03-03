
using System;
using System.Collections.Generic;

namespace ReferenceGame
{
    public class Echidna : Item
    {
        public Echidna()
        {
            LongName = "Echidna";
            CompactName = "echidna";

            ItemActionMessages.Add("examine", "O.M.G. This thing is cute. It looks like a porcupine with a long snoot. And maybe even cuddly?");
            ItemActionMessages.Add("use", "Harry refuses your advances.");
        }

        public override string Use(GarageRoom room)
        {
            if (BeenUsed)
                return $"Sorry, {LongName} has already been used. And he's not happy about your continued advances.";
            else
            {
                BeenUsed = true;

                if (room.WaterLevel > 6 &&
                    room.DoesItemExistInRoom("echidna"))
                {
                    room.RoomContents.Add(room.GetHiddenRoomContentsByName("garagedooropener"));
                    room.RoomContentsAsStringList.Add("Garage Door Opener");
                    room.CurrentScene = room.GarageScenes.ScenesDictionary["Water07_EchidnaAttacksShark"];
                    
                    return "The echidna gives you a li'l kiss on the cheek then dives underwater and attacks the shark! The echidna is eating the shark! He eats a large hole in the shark's belly revealing a... garage door opener? ";
                }
                else
                {
                    BeenUsed = false;
                    return ItemActionMessages["use"];
                }
                
            }
        }

    }

}
