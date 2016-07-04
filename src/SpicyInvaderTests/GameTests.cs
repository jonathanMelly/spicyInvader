using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpicyInvaderTests;
using System;



namespace SpicyInvader.Tests
{
    [TestClass()]
    public class GameTests
    {
        ConsoleWrapper console;

        [TestInitialize]
        public void init()
        {
            console = new TestConsole(10,10);
        }

        [TestMethod()]
        public void GameTest_assertGameCreationOK()
        {

            //Arrange
            Console.Write("nop");
            Game game;

            //Act
            game = new Game(console);
            game.initialize();

            //Assert
            Assert.IsNotNull(game);
            
        }
    }
}