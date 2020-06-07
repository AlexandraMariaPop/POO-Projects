using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ClasaAngajat
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaAngajati<Angajat> initial = new ListaAngajati<Angajat>(CitireAngajatidinFisier.FileReader());
            Console.WriteLine("LISTA INITIALA:");
            Console.WriteLine(initial);
            Console.WriteLine("LISTA ORDONATA ALFABETIC");
            initial.Sort(null);
            List<string> alfabetic = new List<string>();
            List<string> vechime = new List<string>();
            for (int i = 0; i < initial.Length; i++)
            {
                Console.WriteLine(initial[i].LastName+" "+initial[i].FirstName);
                alfabetic.Add(initial[i].LastName + " " + initial[i].FirstName+"\n");
                
            }
            TextWriter tw = new StreamWriter(@"..\..\Alfabetic.txt");
            foreach (var item in alfabetic)
            {
                tw.WriteLine(item);
            }
            Console.WriteLine("VECHIME");
            for (int i = 0; i < initial.Length; i++)
            {
                TimeSpan s1 = DateTime.Now.Subtract(initial[i].Date);
                Console.WriteLine($"{initial[i].LastName } {initial[i].FirstName} VECHIME: {s1} Zile");
                //Console.WriteLine(DateTime.Now-initial[i].Date);
                vechime.Add($"{initial[i].LastName } {initial[i].FirstName} VECHIME: {s1} zile");

            }
            TextWriter tw2 = new StreamWriter(@"..\..\Vechime.txt");
            foreach (var item in vechime)
            {
                tw2.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
