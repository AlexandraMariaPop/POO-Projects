using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textfilehomework
{
    class TEXTFILE
    {
        private string [] sentence;
        private int nroflines = 0;
        private int nrofvowels = 0;
        private int nrofconsonants = 0;
        private int nrofcharacters = 0;
        

        public TEXTFILE(string[] sentence)
        {
            this.sentence = sentence;
        }

        internal int LinesNumber()
        {
            return nroflines = sentence.Length;
        }

        internal int CharactersNumber()
        {
            for (int i = 0; i < sentence.Length; i++)
            {
                foreach (char c in sentence[i])
                    nrofcharacters++;
            }
            return nrofcharacters;
        }

        internal int VowelsNumber()
        {
            for (int i = 0; i < sentence.Length; i++)
            {
                string lines = sentence[i];
                for (int j = 0; j < lines.Length; j++)
                {
                    if ((lines[j] == 'a') || (lines[j] == 'e') || (lines[j] == 'i') || (lines[j] == 'o') || (lines[j] == 'u') || (lines[j] == 'A') || (lines[j] == 'E') || (lines[j] == 'I') || (lines[j] == 'O') || (lines[j] == 'U') || (lines[j] == 'ă') || (lines[j] == 'Ă') || (lines[j] == 'â') || (lines[j] == 'Â') || (lines[j] == 'î') || (lines[j] == 'Î'))
                    {
                        nrofvowels++;
                    }
                    
                }
            }
            return nrofvowels;
        }

        internal int ConsonantsNumber()
        {
            for (int i = 0; i < sentence.Length; i++)
            {
                string lines = sentence[i];
                for (int j = 0; j <lines.Length; j++)
                {
                    
                        if (((lines[j] >= 'a') && (lines[j] <= 'z')) || ((lines[j] >= 'A') && (lines[j] <= 'Z')))
                        nrofconsonants++;
                }
            }
            return nrofconsonants;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            new StreamReader(Console.OpenStandardInput());
            string[] lines = File.ReadAllLines(args[0]);

            TEXTFILE myText = new TEXTFILE(lines);

            Console.WriteLine("In fisier sunt {0} caractere.", myText.CharactersNumber());
            Console.WriteLine("In fisier sunt {0} vocale.", myText.VowelsNumber());
            Console.WriteLine("In fisier sunt {0} consoane.", myText.ConsonantsNumber());
            Console.WriteLine("In fisier sunt {0} linii.", myText.LinesNumber());

            Console.ReadKey();
        }
    }
}
