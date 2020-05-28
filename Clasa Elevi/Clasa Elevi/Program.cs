using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasa_Elevi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se consideră un fișier text de intrare având linii de forma
            //< nume > < prenume > < n > < nota 1 > … < nota n > unde n reprezintă numărul notelor.
            // Datele din fișier se adaugă într-o colecție generică prin intermediul unei clase având ca
            //membrii dată numele, prenumele și media aritmetică a notelor.
            //Să se afișeze într-un fișier de ieșire lista înregistrărilor sortate descrescător în functie 
            //de medie, iar pentru medii egale, alfabetic în funcție de nume și prenume.
            List<Student> students = ReadStudentsFromFile.GetStudentsFromFile();
            for (int i = 0; i < students.Count; i++)
            {
                students[i] = students[i].Formatname();
                Console.WriteLine(students[i]);
            }
            Console.WriteLine("lista sortata:");
            students.Sort();
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
