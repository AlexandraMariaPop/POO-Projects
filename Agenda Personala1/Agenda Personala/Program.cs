using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Personala
{
    class Program
    {
        static void Main(string[] args)
        {
          
            /*List<Person> read = ReadPeoplefromFile.GetPeopleFromFile();
            foreach (Person p in read)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();
            */

            //crearea unei persoane 
            Person Marie = new Person();
            Marie.FirstName = "MARIE";
            Marie.LastName = "ANDERSON";
            Marie.ID = 1;
            Marie.Email = "AAAA@yahoo.com";
            Marie.PhoneNumber = 09876543456789;
            Marie.Age = 44;
            Person Jane=new Person(2,"Doe","Jane",35,8647848723689,"dj@smthing.com");
            Console.WriteLine(Jane);
            Console.WriteLine(Marie);
            //crearea unei agende si adaugarea la lista de agende
            Agenda owner_Marie = new Agenda(Marie);
            Agenda owner_Jane=new Agenda(Jane);

            //crearea unei activitati si adaugare in agenda unei persoane. 
            Event danceparty = new Event("Danceparty","Hamptons",new DateTime(2025, 4, 27, 12, 0, 0),new DateTime(2025,4,27,6,00,00),"bring come food");
            Event meeting=new Event("meeting","Los Angeles",new DateTime(2025,8,15,10,00,00),new DateTime(2025,8,15,15,25,00),"bring presentation");
            Event danceparty2 = new Event("Danceparty2","Hamptons",new DateTime(2020, 5, 27, 12, 0, 0),new DateTime(2020,4,27,6,00,00),"bring some food");
            Event funeral = new Event("aunt Katy will die ", "Cemetery", new DateTime(2020, 11, 1, 12, 0, 0), new DateTime(2020, 11, 1, 15, 00, 00), "bring some flowers");
            owner_Jane.AddEvent(danceparty);
            owner_Marie.AddEvent(danceparty);
            owner_Jane.AddEvent(meeting);
            owner_Jane.AddEvent(danceparty2);
            owner_Jane.AddEvent(funeral);

            Console.WriteLine("AGENDA");
            Console.WriteLine(owner_Jane);
            // cautarea unei activitati dupa nume. 
            //se va intoarce o lista de activitati daca sunt mai multe care respecta criteriile de cautare.
            Console.WriteLine("CAUTAREA DUPA NUMELE EVENIMENTULUI");
            List<Event> search = owner_Jane.SearchEvent("Danceparty");
            foreach(Event e in search)
                Console.WriteLine(e);

            //stergerea unei activitati
            owner_Jane.DeleteEvent(danceparty);

            //generarea unui raport cu toate activitatile unei persoane dintr-un anumit interval de timp
           List<Event>raport= owner_Jane.FindEventsbetween2Dates(new DateTime(2020, 1, 1), new DateTime(2020, 12, 31));
            Console.WriteLine("RAPORT");
            foreach (Event item in raport)
            {
                Console.WriteLine(item);
            }


            //stergerea unei agende
            owner_Jane.DeleteAgenda(); //- stergerea comentariului va avea drept rezultat stergerea agendei,si neafisarea lucrurilor cerute mai sus

            //TODO:
           // pentru un grup de persoane(nu neaparat toate persoanele care sunt in sistem) sa se gaseasca un interval de timp liber
            //(eventual primul interval de timp liber), de o anumita durata, pentru toti in care se poate programa un meeting cu tot grupul.

          Console.ReadKey();
            
        }
    }
}
