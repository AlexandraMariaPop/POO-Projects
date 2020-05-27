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

            List<Person> read = ReadPeopleFromFile.GetPeopleFromFile();
            for (int i = 0; i < read.Count; i++)
            {
                read[i] = read[i].Formatname();
                Console.WriteLine(read[i]);
            }
            Console.WriteLine();
            read.Sort();
            foreach (var item in read)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
