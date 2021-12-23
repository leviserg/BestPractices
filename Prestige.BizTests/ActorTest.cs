using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prestige.Biz;
using System;

namespace Prestige.BizTests
{
    [TestClass]
    public class ActorTest
    {
        [TestMethod]
        public void TestGetOccupation()
        {
            // AAA : Arrange -> Act -> Assert
            // Arrange
            var actor = new Actor();
            var expected = "Actor";

            // Act
            var actual = actor.GetOccupation();

            // Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void TestParameterizedContructor()
        {
            // Arrange
            var actor = new Actor("Jack Reacher");
            string expected = "Jack Reacher";

            // Act
            string actual = actor.ActorName; // press F9 to toggle breakpoint on selected line and chose Debug Selected test in Context menu

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestBookActor()
        {
            // Arrange
            var actor = new Actor("Jack Reacher");
            string expected = "Actor Jack Reacher is booked. Booking can change if actor starts trouble";

            // Act
            string actual = actor.BookActor();

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestBookActorOnSpecificDate()
        {
            // Arrange
            var actor = new Actor("Jack Reacher");
            string specDate = DateTime.Now.AddDays(7).ToString("yyyy-MM-dd");
            string expected = $"Actor Jack Reacher is booked on {specDate}. Booking can change if actor starts trouble";

            // Act
            string actual = actor.BookActor(specDate);

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestAutoPropActorDescription()
        {
            // Arrange
            var actor = new Actor("Jack Reacher");
            string expected = "Regular Actor";

            // Act
            string actual = actor.ActorDescription;

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestInitPropActorDescription()
        {
            // Arrange
            var actor = new Actor { ActorName = "Jack Reacher", ActorDescription = "Initial description" };
            string expected = "Initial description";

            // Act
            string actual = actor.ActorDescription;

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestGetAgency()
        {
            // Arrange
            var actor = new Actor { ActorName = "Jack Reacher", ActorDescription = "Initial description" };
            string expected = "Not default agency"; // "Talent Agency";

            // Act
            string actual = actor.GetAgency();

            // Assert
            Assert.AreEqual(expected, actual);

        }

    }
}
