using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Personala
{
    class Agenda
    {
        private Person owner;
        private List<Event> Eventslist;
       public Agenda(Person owner)
        {
            
            Eventslist = new List<Event>();
            this.owner = owner;
        }

        public void AddEvent(Event imput)
        {
            Eventslist.Add(imput);
            
        }
        public List<Event> SearchEvent(string eventname)
        {
            List<Event> foundevents=new List<Event>();
            foreach(Event e in Eventslist)
            {
                if(e.EventName==eventname)
                    foundevents.Add(e);
            }
            if (foundevents == null)
                throw new Exception("Event not found");
            return foundevents;
            
        }
        public void DeleteEvent(Event todelete)
        {
            Eventslist.Remove(todelete);
        }
        public void DeleteAgenda()
        {
            Eventslist.Clear();
            Console.WriteLine("AGENDA DELETED ");

        }
        internal List<Event> FindEventsbetween2Dates(DateTime starttime, DateTime endtime)
        {
            List<Event> foundevents = new List<Event>();
            foreach(Event searched in Eventslist)
            {
                if (searched.StartTime >= starttime && searched.EndTime <= endtime)
                    foundevents.Add(searched);
            }
            return foundevents;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"AGENDA OWNER: {owner.FirstName}, {owner.LastName}");
            sb.AppendLine();
            foreach (Event todisplay in Eventslist)
            {
                sb.Append(todisplay);
                sb.AppendLine();
            }
            return sb.ToString();
        }

        
    }
}
