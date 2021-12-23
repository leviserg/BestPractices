using Prestige.Common;
using System;
using System.IO;

namespace Prestige.Biz
{
    class Program
    {
        static void Main(string[] args)
        {
            Agency agency = null;
            agency ??= new Agency();

            Console.WriteLine(agency?.Name); // ALWAYS check for null values

            string newTalent = "JackReacher";
            Actor actor = new Actor(newTalent);
            string actorBookDetails = actor.BookActor(DateTime.Now.AddDays(7).ToString("yyyy-MM-dd"));
            Console.WriteLine($"Actor's name is {actor.ActorName}");
            Console.WriteLine(actorBookDetails);
            Console.WriteLine(actor.ActorDescription);

            Console.WriteLine($"Actor's agency is : {actor.ActorAgency.Name}");

            NotificationService.NotificateTalent(newTalent);

            Console.WriteLine();

            string path = "../../../../SourceFile.txt"; //@"c:\temp\MyTest.txt";

            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            else
            {
                Console.WriteLine("File not found");
            }

        }
    }
}
