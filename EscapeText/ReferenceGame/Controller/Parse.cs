using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace ReferenceGame
{
    public class Parse
    {

        public Game game;
        public IView view;
        public GarageRoom room;
        public string[] commands;
        public string InputVerb;
        public string InputNoun;

        /// <summary>
        /// Reads in string, breaks it into array of strings, if no index then "help", else splits first index into verb and remainder into nouns 
        /// </summary>
        /// <param name="s">The user's input</param>
        /// <param name="view">Passed in and overwritten with what will appear in the full console window</param>
        /// <param name="game">Passed in to register when game should be over</param>
        /// <param name="room">Passed in to make changes to the current room</param>
        public Parse(string s, IView view, Game game, GarageRoom room)
        {
            this.game = game;
            this.view = view;
            this.room = room;

            Regex rgx = new Regex(@"[^\w\s]");
            s = rgx.Replace(s, String.Empty);

            s = string.IsNullOrWhiteSpace(s) ? "help" : s;


            s = s.Replace("the ", "");
            commands = s.Trim().ToLower().Split(' ');

            InputVerb = commands[0];

            InputNoun = "";
            for (int i = 1; i < commands.Length; i++)
            {
                InputNoun += commands[i];
            }

        }
        /// <summary>
        /// Executes the command provided by the user. But first...
        ///     Increments water-level if button has been pressed
        ///     Determines which scene should be shown based on state of the room and
        ///     Updates the Screen
        /// </summary>
        /// <returns>the command prompt for next user entry</returns>
        public string ExecuteCommand(GarageRoom currentRoom)
        {
            // Water level tracks the number of moves made
            if (room.GetRoomContentsByName("button").BeenUsed)
                room.WaterLevel++;

            if (room.WaterLevel > 0 && room.WaterLevel < 7)
            {
                // If waterlevel is at a certain height (6) then shark gets added to the room contents 
                if (room.WaterLevel == 6)
                {
                    room.RoomContents.Add(room.GetHiddenRoomContentsByName("shark"));
                    room.RoomContentsAsStringList.Add("Shark");
                }

                if (room.DoesItemExistInRoom("echidna"))
                {
                    string scn = "Water0" + room.WaterLevel + "_EchidnaAndButton";
                    room.CurrentScene = room.GarageScenes.ScenesDictionary[scn];
                }
                else if (!room.DoesItemExistInRoom("echidna"))
                {
                    string scn = "Water0" + room.WaterLevel + "_NoEchidna";
                    room.CurrentScene = room.GarageScenes.ScenesDictionary[scn];
                }
            }
            else if (room.WaterLevel >= 7)
            {
                game.WinLoseLogic(InputVerb, InputNoun);
            }

            // provides default message if item is not in room
            if (!room.DoesItemExistInRoom(InputNoun) && InputNoun != "")
            {
                if (InputNoun == "water")
                    view = new View(room.CurrentScene, room.RoomContentsAsStringList, Display.Wrap($"The WATER tastes like partially digested ants, like echidna poop.", 60));
                else
                    view = new View(room.CurrentScene, room.RoomContentsAsStringList, Display.Wrap($"I'm sorry, {InputNoun.ToUpper()} is not available in the room!", 60));
                return view.UpdateScreenAndGetInput();
            }

            switch (InputVerb)
            {
                case "intro":
                    view = new View(room.CurrentScene, room.RoomContentsAsStringList, Display.Wrap(room.IntroMessage, 60));
                    return view.UpdateScreenAndGetInput();

                case "inspect":
                case "examine":
                    view = new View(room.CurrentScene, room.RoomContentsAsStringList, Display.Wrap(room.GetRoomContentsByName(InputNoun).Examine(), 60));
                    return view.UpdateScreenAndGetInput();

                case "take":
                case "use":
                case "push":
                case "touch":
                    string UseItemSceneUpdate = room.GetRoomContentsByName(InputNoun).Use(room);
                    if (!room.ExitClosed)
                        game.GameState = GameState.Over;
                    view = new View(room.CurrentScene, room.RoomContentsAsStringList, Display.Wrap(UseItemSceneUpdate, 60));
                    return view.UpdateScreenAndGetInput();

                case "help":
                    view = new View(room.CurrentScene, room.RoomContentsAsStringList, Display.Wrap("Try different actions with the items in the room. For example: EXAMINE BUTTON.", 60));
                    return view.UpdateScreenAndGetInput();

                default:
                    view = new View(room.CurrentScene, room.RoomContentsAsStringList, Display.Wrap("Command not found. Type 'help' for a list of commands.", 60));
                    return view.UpdateScreenAndGetInput();
            }
        }

    }
}
