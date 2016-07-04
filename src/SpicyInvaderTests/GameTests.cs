using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpicyInvader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpicyInvader.Tests
{
    [TestClass()]
    public class GameTests
    {
        [TestMethod()]
        public void GameTest_assertGameCreationOK()
        {

            //Arrange
            Console.Write("nop");
            Game game;

            //Act
            game = new Game();

            //Assert
            Assert.IsNotNull(game);
            
        }

        [TestMethod()]
        [ExpectedException(typeof(ApplicationException),
            "No rendering engine defined.\nPlease call method 'setRenderingEngine'")]
        public void GameTest_assertGameCreationWithoutRenderingKO()
        {

            //Arrange
            Console.Write("nop");
            Game game;

            //Act
            game = new Game();

            //Assert
            //Devrait envoyer une exception
            game.start();

        }
    }
}