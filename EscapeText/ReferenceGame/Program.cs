
using System;
using System.Collections.Generic;

/// <summary>
/// Glistening Echidna Text Adventure Game
///     derived from Escape GarageRoom - a game created by Jose Jimenez, Quinn Liu, John Gaines, and Don Pham
/// </summary>

namespace ReferenceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            string input = "intro";

            /// <summary>
            /// Game play happens here and loops through while the gamestate is not Over
            /// </summary>
            while (game.GameState == GameState.PlayOn &&
                    input != "quit")
            {
                Parse parse = new Parse(input, game.view, game, game.currentRoom);
                input = parse.ExecuteCommand(game.currentRoom);

                if (game.GameState != GameState.PlayOn && input == "yes")
                {
                    input = "intro";
                    game = new Game();
                    continue;
                }
            }
        }
    }
}
