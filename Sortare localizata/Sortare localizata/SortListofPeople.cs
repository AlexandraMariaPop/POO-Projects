using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortare_localizata
{
    class SortListofPeople
    {
        public List<Person> initial;
        public SortListofPeople(List<Person> initial)
        {
            initial = new List<Person>();
            this.initial = initial;
            List<Person> final = new List<Person>();
            foreach (Person item in this.initial)
            {
                Person aux = item.Formatname();
                final.Add(aux);
            }
            final.Sort();

        }
        public List<Person> finallist()
        {
            List<Person> final = new List<Person>();
            foreach (Person item in this.initial)
            {
                Person aux = item.Formatname();
                final.Add(aux);
            }
            final.Sort();
            return final;
        }


    }
}
