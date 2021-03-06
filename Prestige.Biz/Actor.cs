using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestige.Biz
{
    public class Actor
    {
        /*
            Clean Code:
                1st - Constructors
                2nd - Properties
                3rd - Methods
         */


        public Actor()
        {
            Console.WriteLine($"{DateTime.Now.ToString("HH:mm:ss")} : default ctor has been called");
            //this.AgentAgency = new Agency(); // if ALWAYS needed in this object in class, BUT this will waist resources
        }

        public Actor(string actorName) : this() // call default constructor and using property instead of parameter 
        {
            ActorName = actorName;
        }


        private string jobTitle;

        public string JobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }

        private string actorName;

        public string ActorName
        {
            get { return actorName; }
            set {
                var formattedName = value?.Trim();
                actorName = formattedName;
                //actorName = value;
            }
        }

        public string ActorDescription { get; set; } = "Regular Actor"; // property initializer

        private Agency actorAgency;

        public Agency ActorAgency
        {
            get {
                /*
                if (agentAgency is null)
                {
                    agentAgency = new Agency(); // Lazy Loading !!! needed SOMETIMES
                }
                return agentAgency;
                */
                return actorAgency ??= new Agency { Name = "Not default agency"};
            }
            set { actorAgency = value; }
        }


        /// <summary>
        /// Returns actor's title
        /// </summary>
        /// <returns>string</returns>
        public string GetOccupation()
        {
            jobTitle = "Actor";
            return jobTitle;
        }

        /// <summary>
        /// Book actor w/o any date specified
        /// </summary>
        /// <returns>string</returns>
        public string BookActor()
        {
            return BookActor(string.Empty);
        }

        /// <summary>
        /// Book actor on specific date
        /// </summary>
        /// <param name="requestDate">YYYY-MM-DD</param>
        /// <returns>string</returns>
        public string BookActor(string requestDate)
        {
            string details = "Booking can change if actor starts trouble";
            if(requestDate != string.Empty)
            {
                return $"Actor {ActorName} is booked on {requestDate}. {details}";
            }
            return $"Actor {ActorName} is booked. {details}";
        }

        public string GetAgency()
        {
            // Agency agency = new Agency(); // if Needed ONCE
            // return agency.Name;
            return ActorAgency.Name; // use another object as property if needed ALWAYS
        }
    }
}
