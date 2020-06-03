using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClasaNames
{
    internal class Names
    {
        private int dimensiune;
        private List<string> nume;
        public Names(int dimensiune)
        {
            this.dimensiune = dimensiune;
            nume = new List<string>(dimensiune);
            for (int i = 0; i < dimensiune; i++)
            {
                nume.Add("Default");
            }
        }
        public string this[int index]
        {
            get
            {
                if ((index >= 0) && (index < dimensiune))
                {
                    string toreturn = nume.ElementAt(index);
                    return toreturn;
                }
                else throw new IndexOutOfRangeException("INDEX WAS OUT OF RANGE");
            }
            set
            {
                if ((index >= 0) && (index < dimensiune))
                {
                    nume.Insert(index, value);
                    nume.RemoveAt(dimensiune );
                }
                else
                    throw new IndexOutOfRangeException("INDEX WAS OUT OF RANGE");
            }
        }
        public string this[string index]
        {
            get
            {
                int idx ;
                bool valid = true;
                try
                {
                     idx = int.Parse(index);
                }
                catch(FormatException)
                {
                    valid = false;
                    throw new Exception("NOT A VALID NUMBER");
                }
                if (valid)
                {
                    idx = int.Parse(index);
                    if ((idx >= 0) && (idx < dimensiune))
                    {
                        string toreturn = nume.ElementAt(idx);
                        return toreturn;
                    }
                    else throw new IndexOutOfRangeException("INDEX WAS OUT OF RANGE");
                }
                else
                {
                    throw new Exception("NOT A VALID NUMBER");
                }
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in nume)
            {
                sb.Append(item + " ");
            }
            return sb.ToString();
        }
    }
}