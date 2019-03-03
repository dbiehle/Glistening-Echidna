
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReferenceGame;

namespace EscapeRoom_Tests
{

    [TestClass]
    public class Parse_Test
    {
     
        DummyView testView = new DummyView();
        Game testGame = new Game();
        GarageRoom testRoom = new Room("Garage");

        [TestMethod]
        public void Parse_Null_ReturnsHelp()
        {
            string testInput = "";

            Parse parse = new Parse(testInput, testView, testGame, testRoom);
            Assert.AreEqual("help",parse.InputVerb);

        }

        [TestMethod]
        public void Parse_Eat_Honey_Bear_ReturnsHoneybear()
        {
            string testInput = "eat honey bear";

            Parse parse = new Parse(testInput, testView, testGame, testRoom);
            Assert.AreEqual("honeybear", parse.InputNoun);

        }

        [TestMethod]
        public void Parse_Honey_Bear_ReturnsHoney()
        {
            string testInput = "honey bear";

            Parse parse = new Parse(testInput, testView, testGame, testRoom);
            Assert.AreEqual("bear", parse.InputNoun);

        }

        [TestMethod]
        public void Parse_Eat_Honey_Bear_Questionmark_ReturnsHoneybear()
        {
            string testInput = "eat honey bear?";

            Parse parse = new Parse(testInput, testView, testGame, testRoom);
            Assert.AreEqual("honeybear", parse.InputNoun);

        }


    }

    
}

