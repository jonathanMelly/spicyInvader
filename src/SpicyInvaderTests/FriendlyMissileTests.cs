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
    public class FriendlyMissileTests
    {
        [TestMethod()]
        public void FriendlyFireTest_assertSymbolIsValid()
        {
            //Arrange
            FriendlyMissile missile = new FriendlyMissile();

            //Act
            string symbol = missile.getSymbol();

            //Assert
            Assert.AreEqual("|", symbol);
        }
    }
}