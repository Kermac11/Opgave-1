using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModelLib;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballplayerTests
{
    [TestClass()]
    public class FootballPlayerTests
    {
        [TestMethod()]
        public void FootballPlayerConstructorTest()
        {
            FootballPlayer testplayer = new FootballPlayer(1, "John", 50, 1);
            Assert.IsNotNull(testplayer);

            Assert.ThrowsException<ArgumentException>(() => testplayer = new FootballPlayer(1, "Per", 50, 1));

            Assert.ThrowsException<ArgumentException>(() => testplayer = new FootballPlayer(1, "John", 0, 1));

            Assert.ThrowsException<ArgumentException>(() => testplayer = new FootballPlayer(1, "John", 50, 2001));

        }

        [TestMethod()]
        public void PropertyChangeTest()
        {
            FootballPlayer testplayer = new FootballPlayer(1, "John", 50, 1);
            Assert.IsNotNull(testplayer);

            Assert.ThrowsException<ArgumentException>(() => testplayer.Name = "Ib");

            Assert.ThrowsException<ArgumentException>(() => testplayer.Price = -20);

            Assert.ThrowsException<ArgumentException>(() => testplayer.ShirtNumber = 200);

            Assert.ThrowsException<ArgumentException>(() => testplayer.ShirtNumber = 0);

        }
    }
}