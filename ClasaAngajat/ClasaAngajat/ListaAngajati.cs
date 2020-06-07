using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasaAngajat
{
    public class ListaAngajati<T>
    {
        private List<T> angajati;
        public ListaAngajati(List<T> angajati)
        {
            this.angajati = new List<T>();
            this.angajati = angajati;
        }
        public void Add(T toAdd)
        {
            angajati.Add(toAdd);
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Remove(T toRemove)
        {
            angajati.Remove(toRemove);
        }



        public void Sort(Comparison<T> comparer)
        {
            if (comparer != null)
                angajati.Sort(comparer);
            else
                angajati.Sort();
        }
        public T this [int index]=> angajati[index];
           public int Length
        {
            get
            {
                return angajati.Count();
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in angajati )
            {
                sb.Append(item + " ");
                sb.AppendLine();
            }
            return sb.ToString();
        }

        
    }
}
