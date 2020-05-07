using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Sortare_localizata
{
    class ReadPeopleFromFile
    {
        public static List<Person> GetPeopleFromFile()
        {
            List<Person> people = new List<Person>();
            string[] linesfromfile = File.ReadAllLines(@"..\..\people.txt");
            char[] sep = { ' ', ';', ',', '.', ':', '!', '?',' ','*' };
           for (int i = 0; i < linesfromfile.Length; i++)
            {
                
                string[] eachline = linesfromfile[i].Split(sep);
                string lastname = eachline[0];
                List<string> Listfirstname = new List<string>();
                for (int k = 1; k < eachline.Length; k++)
                {
                    Listfirstname.Add(eachline[k]);
                }
                StringBuilder sb = new StringBuilder();
                foreach (string aux in Listfirstname)
                    sb.Append(aux + " ");
                Person p1 = new Person(lastname, sb.ToString());
                people.Add(p1);
            }
            return people;
        }

    }
}
