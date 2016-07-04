using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpicyInvader;
using System;


namespace SpicyInvader.Tests
{
    [TestClass()]
    public class ShipTests
    {
        Ship ship;

        

        [TestMethod()]
        public void ShipTest_assertOnly1MissileCanBeFiredAtTheSameTime()
        {
            //Arrange
            createShipAtPosition10WithLimitAt20();

            //Act
            ship.fire();

            //Tire une 2ème fois => premier missile pas encore détruit
            bool fired = ship.fire();

            //Assert
            Assert.IsFalse(fired);
        }

        [TestMethod()]
        public void ShipTest_assertMoveLeft()
        {
            //Arrange
            createShipAtPosition10WithLimitAt20();
            short initialPosition = ship.getPosition();

            //Act
            ship.moveLeft();

            //Assert
            Assert.AreEqual(initialPosition - Game.SHIP_SPEED, ship.getPosition());
        }

        [TestMethod()]
        public void ShipTest_assertMoveLeftUntilEndOfScreen()
        {
            //Arrange
            createShipAtPosition10WithLimitAt20();

            //Act
            for(int i=0;i<50;i++)
            {
                ship.moveLeft();
            }


            //Assert
            Assert.AreEqual(0, ship.getPosition());
        }

        [TestMethod()]
        public void ShipTest_assertMoveRight()
        {
            throw new NotImplementedException();
        }

        //Aides aux tests
        private void createShipAtPosition10WithLimitAt20()
        {
            ship = new Ship(10,20);
        }
    }
}