
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReferenceGame;

namespace EscapeRoom_Tests
{
    [TestClass]
    public class Room_DoesItemExistInRoom_Test
    {
        GarageRoom testRoom = new GarageRoom("Garage");

        [TestMethod]
        public void Blanket_ExpectTrue()
        {

            bool testExists = testRoom.DoesItemExistInRoom("blanket");
            Assert.IsTrue(testExists);

        }
        [TestMethod]
        public void Shark_ExpectFalse()
        {

            bool testExists = testRoom.DoesItemExistInRoom("shark");
            Assert.IsFalse(testExists);

        }

    }

    [TestClass]
    public class Room_GetRoomContentsByName_Test
    {
        GarageRoom testRoom = new GarageRoom("Garage");

        [TestMethod]
        public void Echidna_ExpectNull()
        {

            Item testItem = testRoom.GetRoomContentsByName("echidna");

            Assert.IsNull(testItem);
        }

        [TestMethod]
        public void Blanket_ExpectNotNull()
        {

            Item testItem = testRoom.GetRoomContentsByName("blanket");

            Assert.IsNotNull(testItem);
        }
    }

    [TestClass]
    public class Room_GetHiddenRoomContentsByName_Test
    {
        GarageRoom testRoom = new GarageRoom("Garage");

        [TestMethod]
        public void Echidna_ExpectNotNull()
        {

            Item testItem = testRoom.GetHiddenRoomContentsByName("echidna");

            Assert.IsNotNull(testItem);
        }

        [TestMethod]
        public void Blanket_ExpectNull()
        {

            Item testItem = testRoom.GetHiddenRoomContentsByName("blanket");

            Assert.IsNull(testItem);
        }
    }
    
    [TestClass]
    public class Room_WinLoseLogic_Test
    {
        GarageRoom testRoom = new GarageRoom("Garage");

        [TestMethod]
        public void WinLoseLogic_Expect_WrongScene()
        {
            testRoom.WaterLevel = 7;

            testRoom.WinLoseLogic();
        }
    }

}

