using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prestige.Common;

namespace Prestige.CommonTests
{
    [TestClass]
    public class NotificationServiceTest
    {
        [TestMethod]
        public void TestNotifyTalent()
        {
            // Arrange
            string TalentName = "Jack Reacher";
            var expected = $"New talent added : {TalentName}";

            // Act
            var actual = NotificationService.NotificateTalent(TalentName);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
