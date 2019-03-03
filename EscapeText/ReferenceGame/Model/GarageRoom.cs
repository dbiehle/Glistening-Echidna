using System;
using System.Collections.Generic;
using System.Linq;


/// <summary>
/// Includes all of the elements of the room: 
///     the water level which presents danger at many levels(!),
///     the visual scenes,
///     the RoomContents and HiddenRoomContents are populated here, too
/// </summary>
namespace ReferenceGame
{
    public class GarageRoom
    {
        public string Name { get; set; }
        public int WaterLevel { get; set; } = 0;
        public bool ExitClosed { get; set; } = true;

        public string IntroMessage;
        public Scenes GarageScenes = new Scenes();

        public List<Item> HiddenRoomContents = new List<Item>();
        public List<Item> RoomContents = new List<Item>();
        public List<string> RoomContentsAsStringList = new List<string>();
        public List<string> CurrentScene { get; set; } = new List<string>();

        public GarageRoom(string name)
        {
            Console.Title = "Glistening Echidna - Escape GarageRoom";
            Name = name;

            CurrentScene = GarageScenes.ScenesDictionary["start"];

            // GarageRoom Items
            RoomContents.Add(new Honeybear());
            RoomContents.Add(new Button());
            RoomContents.Add(new Blanket());

            foreach (Item item in RoomContents)
            {
                RoomContentsAsStringList.Add(item.LongName);
            }
            // TODO: Add water?
            HiddenRoomContents.Add(new Echidna());
            HiddenRoomContents.Add(new Shark());
            HiddenRoomContents.Add(new GarageDoorOpener());
        }

        /// <summary>
        /// 3 Quick checks used in Parse logic to direct game
        /// </summary>
        /// <param name="cn">CompactName of item</param>
        public bool DoesItemExistInRoom(string cn)
        {
            if (RoomContents.FindIndex(x => x.CompactName == cn) >= 0)
                return true;
            else
                return false;
        }

        public Item GetRoomContentsByName(string cn)
        {
            return RoomContents.Find(x => x.CompactName == cn);
        }

        public Item GetHiddenRoomContentsByName(string cn)
        {
            return HiddenRoomContents.Find(x => x.CompactName == cn);
        }

        
    }
}
