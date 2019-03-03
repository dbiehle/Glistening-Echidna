
using System;
using System.Collections.Generic;

/// <summary>
/// Includes the basic elements to play game and instantiate room and its items
/// </summary>
namespace ReferenceGame
{
    public enum GameState
    {
        Over,
        PlayOn
    }

    public class Game
    {
        public GameState GameState { get; set; } = GameState.PlayOn;
        public GarageRoom currentRoom;
        public View view;

        public Game()
        {
            GarageRoom garage = new GarageRoom("Garage")
            {
                IntroMessage = "You're in a room with only a few items in it and no apparent way in or out. You see a button on the wall, one of those honey containers shaped like a bear, and a blanket piled up in the corner. ",
            };

            currentRoom = garage;
        }

        /// <summary>
        /// Conditions to win or lose room level
        /// used within Parse class, ExecuteCommand method
        /// </summary>
        /// <returns>the command prompt after updating view with changes to the scene, room contents, and story text</returns> 
        /// <param name="inputVerb">Parsed first part of user input</param>
        /// <param name="inputNoun">Parsed second part of user input</param>
        public string WinLoseLogic(string inputVerb, string inputNoun)
        {
            // Could continue on and win, but if user didn't type in 'use echidna' after shark appeared, game is over.
            if (currentRoom.DoesItemExistInRoom("echidna") && currentRoom.WaterLevel == 7 &&
                       currentRoom.GetRoomContentsByName("honeybear").BeenUsed)
            {
                if (!(inputNoun == "echidna" && inputVerb == "use"))
                {
                    string scn = "Water0" + currentRoom.WaterLevel + "_EchidnaAndButton";
                    currentRoom.CurrentScene = currentRoom.GarageScenes.ScenesDictionary[scn];
                    GameState = GameState.Over;
                    view = new View(currentRoom.CurrentScene, currentRoom.RoomContentsAsStringList, Display.Wrap("The shark eats you with a great passion. You are dead. Play again? Yes?", 60));
                }
                // if you made the correct move here, just return to get out of the method and move on to the switch case in Parse
                return inputNoun;

            }

            // Lose logic in remaining else-if statements
            else if (!currentRoom.DoesItemExistInRoom("echidna") && currentRoom.WaterLevel == 7)
            {
                GameState = GameState.Over;
                string scn = "Water0" + currentRoom.WaterLevel + "_NoEchidna";
                currentRoom.CurrentScene = currentRoom.GarageScenes.ScenesDictionary[scn];
                view = new View(currentRoom.CurrentScene, currentRoom.RoomContentsAsStringList, Display.Wrap("The shark eats you with a great passion. You are dead. Play again? Yes?", 60));
            }
            else if (currentRoom.DoesItemExistInRoom("echidna") && currentRoom.WaterLevel == 7 &&
                        !currentRoom.GetRoomContentsByName("honeybear").BeenUsed)
            {
                GameState = GameState.Over;
                string scn = "Water0" + currentRoom.WaterLevel + "_EchidnaAndButton";
                currentRoom.CurrentScene = currentRoom.GarageScenes.ScenesDictionary[scn];
                view = new View(currentRoom.CurrentScene, currentRoom.RoomContentsAsStringList, Display.Wrap("The shark eats you with a great passion. You are dead. Play again? Yes?", 60));
            }

            else if (currentRoom.WaterLevel >= 8 &&
                        !(inputNoun == "garagedooropener" &&
                          (inputVerb == "use" || inputVerb == "push" || inputVerb == "take" || inputVerb == "touch")))
            {
                GameState = GameState.Over;
                currentRoom.CurrentScene = currentRoom.GarageScenes.ScenesDictionary["Water08_EchidnaAttackedShark"];
                view = new View(currentRoom.CurrentScene, currentRoom.RoomContentsAsStringList, Display.Wrap("The water fills the room and you and the echidna drown. Play again? Yes?", 60));
            }
            else
                return inputNoun;

            return view.UpdateScreenAndGetInput();
        }

    }
}
