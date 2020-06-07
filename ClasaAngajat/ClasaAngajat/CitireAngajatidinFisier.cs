using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ClasaAngajat
{
    class CitireAngajatidinFisier
    {
        public static List<Angajat> FileReader()
        {
            List<Angajat> Angajati = new List<Angajat>();
            string[] linesfromfile = File.ReadAllLines(@"..\..\Angajati.txt");
            char[] sep = { ' ', ';', ',', '.', ':', '!', '?', ' ', '*' };
            for (int i = 0; i < linesfromfile.Length; i++)
            {

                string[] eachline = linesfromfile[i].Split(sep);
                string lastname = eachline[0];
                string firstname = eachline[1];
                DateTime data = new DateTime(int.Parse(eachline[4]), int.Parse(eachline[3]), int.Parse(eachline[2]));
                
                Angajat a1 = new Angajat(lastname, firstname, data);
                Angajati.Add(a1);
            }
            return Angajati;
        }
    }
}
