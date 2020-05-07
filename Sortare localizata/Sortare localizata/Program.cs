using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortare_localizata
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Person> lines = ReadPeopleFromFile("..\..\people.csv");
           

            Person p1 = new Person("pop", "alexandra", "maria", "pop");
            List<Person> read = ReadPeopleFromFile.GetPeopleFromFile();
            foreach (Person p in read)
            {
               // Person aux = p.Formatname();
                Console.WriteLine(p);
            }
            Console.WriteLine();
            //p1.Formatname();
            Console.WriteLine(p1.Formatname());
            Console.ReadKey();
        }
    }
}
