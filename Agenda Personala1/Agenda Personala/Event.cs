using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Personala
{
    class Event
    {
        private string location;
        private DateTime starttime;
        private DateTime endtime;
        private string eventname;
        private string details;
        public List<Person> InvolvedPeople;
        
        public Event()
        {
            location = "";
            eventname = "";
            details = "";
            InvolvedPeople = new List<Person>();

        }
        public Event(string eventname, string location, DateTime starttime, DateTime endtime, string details)
        {
            this.eventname = eventname;
            this.location = location;
            this.starttime = starttime;
            this.endtime = endtime;
            this.details = details;
            InvolvedPeople = new List<Person>();
        }
        public string EventName
        {
            get
            {
                return eventname;

            }
            set
            {
                eventname = value;
            }
        }
        public string Location
        {
            get
            {
                return location;

            }
            set
            {
                location = value;
            }
        }
        public DateTime StartTime
        {
            get
            {
                return starttime;
            }
            set
            {
                starttime = value;
            }
        }
        public DateTime EndTime
        {
            get
            {
                return endtime;
            }
            set
            {
                endtime = value;
            }
        }
        public string Details
        {
            get
            {
                return details;

            }
            set
            {
                details = value;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            sb.Append("EVENT NAME: " + eventname + ", ");
            sb.Append("LOCATION: " + location + ", ");
            sb.Append("START TIME " + starttime.ToString() + ", ");
            sb.Append("END TIME " + endtime.ToString() + ", ");
            sb.Append("DETAILS " + details);
            sb.Append("]");
            return sb.ToString();
        }
    }
}
