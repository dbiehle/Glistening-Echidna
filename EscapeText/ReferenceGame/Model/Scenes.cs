﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ReferenceGame
{
    public class Scenes
    {
        public Dictionary<string, List<string>> ScenesDictionary = new Dictionary<string, List<string>>();

        public Scenes()
        {
            ScenesDictionary.Add("start", Scenes01);
            ScenesDictionary.Add("Water00_ButtonNoEchidna", Water00_ButtonNoEchidna);
            ScenesDictionary.Add("Water00_EchidnaNotButton", Water00_EchidnaNotButton);
            ScenesDictionary.Add("Water00_EchidnaAndButton", Water00_EchidnaAndButton);

            ScenesDictionary.Add("Water01_EchidnaAndButton", Water01_EchidnaAndButton);
            ScenesDictionary.Add("Water02_EchidnaAndButton", Water02_EchidnaAndButton);
            ScenesDictionary.Add("Water03_EchidnaAndButton", Water03_EchidnaAndButton);
            ScenesDictionary.Add("Water04_EchidnaAndButton", Water04_EchidnaAndButton);
            ScenesDictionary.Add("Water05_EchidnaAndButton", Water05_EchidnaAndButton);
            ScenesDictionary.Add("Water06_EchidnaAndButton", Water06_EchidnaAndButton);
            ScenesDictionary.Add("Water07_EchidnaAndButton", Water07_EchidnaAndButton);
            ScenesDictionary.Add("Water07_EchidnaAttacksShark", Water07_EchidnaAttacksShark);
            ScenesDictionary.Add("Water08_EchidnaAttackedShark", Water08_EchidnaAttackedShark);

            ScenesDictionary.Add("Water01_NoEchidna", Water01_NoEchidna);
            ScenesDictionary.Add("Water02_NoEchidna", Water02_NoEchidna);
            ScenesDictionary.Add("Water03_NoEchidna", Water03_NoEchidna);
            ScenesDictionary.Add("Water04_NoEchidna", Water04_NoEchidna);
            ScenesDictionary.Add("Water05_NoEchidna", Water05_NoEchidna);
            ScenesDictionary.Add("Water06_NoEchidna", Water06_NoEchidna);
            ScenesDictionary.Add("Water07_NoEchidna", Water07_NoEchidna);

            ScenesDictionary.Add("WinScreen", WinScreen);

        }

        public List<string> Scenes01 { get; } = new List<string>
        {
@"                                                                      ",
@"    0================================================================0",
@"    |                                                                |",
@"    |          _____________________________________________         |",
@"    |         :                                             :        |",
@"    |         :                                             :        |",
@"    |         :                                             :        |",
@"    |         :          o.^.o                              :        |",
@"    |   /|    :          ((^))                              :        |",
@"    |  |=O    :        __O/_\O__                            :        |",
@"    |  |/     :                                             :        |",
@"    |         :                                             :        |",
@"    |         :                                             :        |",
@"    |         :______________________________.-'```-._._.,__:        |",
@"    |       .'                              /-   ~~~   _/    '.      |",
@"    |     .'                                '._.-'-._.-'       '.    |",
@"    |   .'                                                       '.  |",
@"    | .'                                                           '.|",
@"    0================================================================0",
@"                                                                      "
        };

        public List<string> Water00_ButtonNoEchidna { get; } = new List<string>
        {
@"                                                                      ",
@"    0================================================================0",
@"    |                                                                |",
@"    |          _____________________________________________         |",
@"    |         :                                             :        |",
@"    |         :                                             :        |",
@"    |         :                                             :        |",
@"    |         :          o.^.o                              :        |",
@"    |   /|    :          ((^))                              :        |",
@"    |  |O|    :        __O/_\O__                            :        |",
@"    |  |/     :                                             :        |",
@"    |         :                                             :        |",
@"    |         :                                             :        |",
@"    |         :______________________________.-'```-._._.,__:        |",
@"    |       .'                              /-   ~~~   _/    '.      |",
@"    |     .'                                '._.-'-._.-'       '.    |",
@"    |   .'                                                       '.  |",
@"    | .'                                                           '.|",
@"    0================================================================0",
@"                                                                      "
        };

        public List<string> Water00_EchidnaNotButton { get; } = new List<string>
        {
@"                                                                      ",
@"    0================================================================0",
@"    |                                                                |",
@"    |          _____________________________________________         |",
@"    |         :                                             :        |",
@"    |         :                                             :        |",
@"    |         :                                             :        |",
@"    |         :          o.^.o                              :        |",
@"    |   /|    :          ((^))                              :        |",
@"    |  |=O    :        __O/_\O__                            :        |",
@"    |  |/     :                                             :        |",
@"    |         :                                             :        |",
@"    |         :                                             :        |",
@"    |         :___________________ /////_____.-'```-._._.,__:        |",
@"    |       .'                 .__///////   /-   ~~~   _/    '.      |",
@"    |     .'                    \'///////_  '._.-'-._.-'       '.    |",
@"    |   .'                        '   '                          '.  |",
@"    | .'                                                           '.|",
@"    0================================================================0",
@"                                                                      "
        };

        public List<string> Water00_EchidnaAndButton { get; } = new List<string>
        {
@"                                                                      ",
@"    0================================================================0",
@"    |                                                                |",
@"    |          _____________________________________________         |",
@"    |         :                                             :        |",
@"    |         :                                             :        |",
@"    |         :                                             :        |",
@"    |         :          o.^.o                              :        |",
@"    |   /|    :          ((^))                              :        |",
@"    |  |O|    :        __O/_\O__                            :        |",
@"    |  |/     :                                             :        |",
@"    |         :                                             :        |",
@"    |         :                                             :        |",
@"    |         :___________________ /////_____.-'```-._._.,__:        |",
@"    |       .'                 .__///////   /-   ~~~   _/    '.      |",
@"    |     .'                    \'///////_  '._.-'-._.-'       '.    |",
@"    |   .'                        '   '                          '.  |",
@"    | .'                                                           '.|",
@"    0================================================================0",
@"                                                                      "
        };

        public List<string> Water01_EchidnaAndButton { get; } = new List<string>
        {
@"                                                                      ",
@"    0================================================================0",
@"    |                                                                |",
@"    |          _____________________________________________         |",
@"    |         :                                             :        |",
@"    |         :                                             :        |",
@"    |         :                                             :        |",
@"    |         :          o.^.o                              :        |",
@"    |   /|    :          ((^))                              :        |",
@"    |  |O|    :        __O/_\O__                            :        |",
@"    |  |/     :                                             :        |",
@"    |         :                                             :        |",
@"    |         :                    /////                    :        |",
@"    |         :________________.__///////____.-'```-._._.,__:        |",
@"    |       .'                  \'///////_  /-   ~~~   _/    '.      |",
@"    |^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    0================================================================0",
@"                                                                      "
        };

        public List<string> Water02_EchidnaAndButton { get; } = new List<string>
        {
            @"                                                                      ",
@"    0================================================================0",
@"    |                                                                |",
@"    |          _____________________________________________         |",
@"    |         :                                             :        |",
@"    |         :                                             :        |",
@"    |         :                                             :        |",
@"    |         :          o.^.o                              :        |",
@"    |   /|    :          ((^))                              :        |",
@"    |  |O|    :        __O/_\O__                            :        |",
@"    |  |/     :                     /////                   :        |",
@"    |         :                .__ ///////                  :        |",
@"    |         :                 \'///////_                  :        |",
@"    |^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    0================================================================0",
@"                                                                          "
        };


        public List<string> Water03_EchidnaAndButton { get; } = new List<string>
        {
@"                                                                      ",
@"    0================================================================0",
@"    |                                                                |",
@"    |          _____________________________________________         |",
@"    |         :                                             :        |",
@"    |         :                                             :        |",
@"    |         :                                             :        |",
@"    |         :          o.^.o                              :        |",
@"    |   /|    :          ((^))        /////                 :        |",
@"    |  |O|    :        __O/_\O__ .__ ///////                :        |",
@"    |  |/     :                   \'///////                 :        |",
@"    |^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    0================================================================0",
@"                                                                        "
        };


        public List<string> Water04_EchidnaAndButton { get; } = new List<string>
        {
@"                                                                      ",
@"    0================================================================0",
@"    |                                                                |",
@"    |          _____________________________________________         |",
@"    |         :                                             :        |",
@"    |         :                                             :        |",
@"    |         :                        /////                :        |",
@"    |         :          o.^.o    .__ ///////               :        |",
@"    |   /|    :          ((^))     \'///////                :        |",
@"    |^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    0================================================================0",
@"                                                                      "
        };

        public List<string> Water05_EchidnaAndButton { get; } = new List<string>
        {
@"                                                                      ",
@"    0================================================================0",
@"    |                                                                |",
@"    |          _____________________________________________         |",
@"    |         :                            /////            :        |",
@"    |         :                        .__///////           :        |",
@"    |         :                         \'///////           :        |",
@"    |^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    0================================================================0",
@"                                                                        "
        };

        public List<string> Water06_EchidnaAndButton { get; } = new List<string>
        {


@"                                                                      ",
@"    0================================================================0",
@"    |                                      /////                     |",
@"    |          ________________________.__///////___________         |",
@"    |         :                         \'///////           :        |",
@"    |^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~\_____)\_____~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~/--v____ __`<~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~ )/ ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    0================================================================0",
@"                                                                        "
        };

        public List<string> Water07_EchidnaAndButton { get; } = new List<string>
        {
@"                                                                      ",
@"    0================================================================0",
@"    |                                     /////                      |",
@"    |^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~(..       \_~~~~~~~|\  /|~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~\       0  \~~/|~~\ \/ /~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~\______    \/ |~~~\  /~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~vvvv\    \ |~~~/  |~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~\^^^^  ==   \~/   |~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~\_   ===    \.  |~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~/ /\_   \ /      |~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~|/   \_  \|      /~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\________/~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    0================================================================0",
@"                                                                          "
        };

        public List<string> Water07_EchidnaAttacksShark { get; } = new List<string>
        {

@"                                                                      ",
@"    0================================================================0",
@"    |                ____/(_  __ /   .__///////                      |",
@"    |^~^~^~^~^~^~^~^~>_x_  _##v--\ ^~ \*///////^~^~^~^~^~^~^~^~^~^~^~|",
@"    |~~~~~~~~~~~~~~~~~~~~\(~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    0================================================================0",
@"                                                                        "
        };

        public List<string> Water08_EchidnaAttackedShark { get; } = new List<string>
        {
@"                                                                      ",
@"    0================================================================0",
@"    |^~^~^~^~^~^~^~^~____/(_  __ / ^~^~^~^~^/////~~^~^~^~^~^~^~^~^~^~|",
@"    |~~~~~~~~~~~~~~~~>_x_  _##v--\ ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~\(~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    0================================================================0",
@"                                                                        "
        };
        public List<string> Water01_NoEchidna { get; } = new List<string>
        {
@"                                                                      ",
@"    0================================================================0",
@"    |                                                                |",
@"    |          _____________________________________________         |",
@"    |         :                                             :        |",
@"    |         :                                             :        |",
@"    |         :                                             :        |",
@"    |         :          o.^.o                              :        |",
@"    |   /|    :          ((^))                              :        |",
@"    |  |O|    :        __O/_\O__                            :        |",
@"    |  |/     :                                             :        |",
@"    |         :                                             :        |",
@"    |         :                                             :        |",
@"    |         :______________________________.-'```-._._.,__:        |",
@"    |       .'                              /-   ~~~   _/    '.      |",
@"    |^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    0================================================================0",
@"                                                                      "
        };

        public List<string> Water02_NoEchidna { get; } = new List<string>
        {
@"                                                                      ",
@"    0================================================================0",
@"    |                                                                |",
@"    |          _____________________________________________         |",
@"    |         :                                             :        |",
@"    |         :                                             :        |",
@"    |         :                                             :        |",
@"    |         :          o.^.o                              :        |",
@"    |   /|    :          ((^))                              :        |",
@"    |  |O|    :        __O/_\O__                            :        |",
@"    |  |/     :                                             :        |",
@"    |         :                                             :        |",
@"    |         :                                             :        |",
@"    |^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    0================================================================0",
@"                                                                      "
        };

        public List<string> Water03_NoEchidna { get; } = new List<string>
        {
@"                                                                      ",
@"    0================================================================0",
@"    |                                                                |",
@"    |          _____________________________________________         |",
@"    |         :                                             :        |",
@"    |         :                                             :        |",
@"    |         :                                             :        |",
@"    |         :          o.^.o                              :        |",
@"    |   /|    :          ((^))                              :        |",
@"    |  |O|    :        __O/_\O__                            :        |",
@"    |  |/     :                                             :        |",
@"    |^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    0================================================================0",
@"                                                                      "
        };

        public List<string> Water04_NoEchidna { get; } = new List<string>
        {
@"                                                                      ",
@"    0================================================================0",
@"    |                                                                |",
@"    |          _____________________________________________         |",
@"    |         :                                             :        |",
@"    |         :                                             :        |",
@"    |         :                                             :        |",
@"    |         :          o.^.o                              :        |",
@"    |   /|    :          ((^))                              :        |",
@"    |^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    0================================================================0",
@"                                                                      "
        };

        public List<string> Water05_NoEchidna { get; } = new List<string>
        {
@"                                                                      ",
@"    0================================================================0",
@"    |                                                                |",
@"    |          _____________________________________________         |",
@"    |         :                                             :        |",
@"    |         :                                             :        |",
@"    |         :                                             :        |",
@"    |^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    0================================================================0",
@"                                                                      "
        };

        public List<string> Water06_NoEchidna { get; } = new List<string>
        {
@"                                                                      ",
@"    0================================================================0",
@"    |                                                                |",
@"    |          _____________________________________________         |",
@"    |         :                                             :        |",
@"    |^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~\_____)\_____~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~/--v____ __`<~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~)/~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    0================================================================0",
@"                                                                      "
        };

        public List<string> Water07_NoEchidna { get; } = new List<string>
        {
@"                                                                      ",
@"    0================================================================0",
@"    |                                                                |",
@"    |^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~(..       \_~~~~~~~|\  /|~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~\       0  \~~/|~~\ \/ /~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~\______    \/ |~~~\  /~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~vvvv\    \ |~~~/  |~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~\^^^^  ==   \~/   |~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~\_   ===    \.  |~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~/ /\_   \ /      |~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~|/   \_  \|      /~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\________/~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|",
@"    0================================================================0",
@"                                                                      "
        };

        public List<string> WinScreen { get; } = new List<string>
        {
@"                                                                      ",
@"    0================================================================0",
@"    |                                                                |",
@"    |          _____________________________________________         |",
@"    |         :                                             :        |",
@"    |         :                                             :        |",
@"    |         :                                             : |\     |",
@"    |         :          o.^.o                              : | \    |",
@"    |   /|    :          ((^))                              : |  \   |",
@"    |  |O|    :        __O/_\O__                   EXIT ->  : |   |  |",
@"    |  |/     :                                             : |   |  |",
@"    |         :                                             : |   |  |",
@"    |         :                                             : |   |  |",
@"    |         :______________________________.-'```-._.\\\\\  |   |  |",
@"    |       .'   ____/(_  __ /              /-   ~~~   \\\\\\\__. |  |",
@"    |     .'     >_x_  _##---\              '._.-'-._._\\\\\\\'/ \|  |",
@"    |   .'           \(                                 '  '     '.  |",
@"    | .'                                                           '.|",
@"    0================================================================0",
@"                                                                      "
        };

    }
}

