using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Agenda_Personala
{
   public class ReadPeoplefromFile
    {
        public static List<Person> GetPeopleFromFile()
        {
            List<Person> people = new List<Person>();
            string[] linesfromfile = File.ReadAllLines(@"..\..\PeopleImput.csv");
            for (int i = 0; i < linesfromfile.Length; i++)
            {
                string[] eachline = linesfromfile[i].Split(',');
                int id = int.Parse(eachline[0]);
                string lastname = eachline[1];
                string firstname = eachline[2];
                int age = int.Parse(eachline[3]);
                long phonenumber = long.Parse(eachline[4]);
                string email = eachline[5];
                Person p1 = new Person(id, lastname, firstname, age, phonenumber, email);
                people.Add(p1);
            }
            return people;
        }
    }
}
