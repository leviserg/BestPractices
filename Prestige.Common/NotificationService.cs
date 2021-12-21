using System;

namespace Prestige.Common
{
    public static class NotificationService
    {
        /// <summary>
        /// Nitifies about new talent found and added
        /// </summary>
        /// <param name="talentName">string</param>
        /// <returns>string</returns>
        public static string NotificateTalent(string talentName)
        {
            string message = $"New talent added : {talentName}";
            Console.WriteLine(message);
            return message;
        }
    }
}
