using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Clasa_Elevi
{
    class ReadStudentsFromFile
    {
        public static List<Student> GetStudentsFromFile()
        {
            List<Student> students = new List<Student>();
            string[] linesfromfile = File.ReadAllLines(@"..\..\Students.txt");
            char[] sep = { ' ', ';', ',', '.', ':', '!', '?', ' ', '*' };
            for (int i = 0; i < linesfromfile.Length; i++)
            {

                string[] eachline = linesfromfile[i].Split(sep);
                string lastname = eachline[0];
                string firstname = eachline[1];
                int nrnote = int.Parse(eachline[2]);
                //int[] note = new int[int.Parse(eachline[2])];
                double media = 0;
                for (int k = 3; k < eachline.Length; k++)
                {
                    media = media + int.Parse(eachline[k]);
                }
                media = media / nrnote;
                Student s1 = new Student(lastname, firstname, media);
                students.Add(s1);
            }
            return students;
        }
    }
}
