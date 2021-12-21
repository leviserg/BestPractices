using Prestige.Common;
using System;

namespace Prestige.Biz
{
    class Program
    {
        static void Main(string[] args)
        {
            string newTalent = "JackReacher";
            Actor actor = new Actor(newTalent);
            string actorBookDetails = actor.BookActor(DateTime.Now.AddDays(7).ToString("yyyy-MM-dd"));
            Console.WriteLine($"Actor's name is {actor.ActorName}");
            Console.WriteLine(actorBookDetails);
            Console.WriteLine(actor.ActorDescription);
            NotificationService.NotificateTalent(newTalent);
        }
    }
}
