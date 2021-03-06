﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace Sortare_localizata
{
    class Person : IEquatable<Person>, IComparable<Person>
    {
        private string lastname;
        private List<string> firstname;
        public Person(string lastname, params string[] firstname)
        {
            this.lastname = lastname;
            this.firstname = new List<string>();
            foreach (string towrite in firstname)
            {
                this.firstname.Add(towrite);
            }
        }
        public string LastName
        {
            get
            {
                return lastname;
            }

            set
            {
                lastname = value;
            }


        }
        public string FirstName
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach (string name in firstname)
                    sb.Append(name + " ");
                return sb.ToString();
            }
            set
            {
                firstname.Add(value);
            }
        }
        public Person Formatname()
        {
            string initiallastname = this.lastname;
            char[] finallastname = initiallastname.ToCharArray();
            finallastname[0] = char.ToUpper(finallastname[0]);
            for (int i = 1; i < finallastname.Length; i++)
            {
                finallastname[i] = char.ToLower(finallastname[i]);
            }
            List<string> aux = new List<string>();
            foreach (var item in firstname)
            {
                aux.Add(item);
            }
            StringBuilder sb = new StringBuilder();
            foreach (string name in aux)
            {

                char[] a = name.ToCharArray();
                a[0] = char.ToUpper(a[0]);
                for (int i = 1; i < a.Length; i++)
                {
                    a[i] = char.ToLower(a[i]);
                }
                sb.Append(new string(a));
                sb.Append(" ");
            }
            sb.Length = sb.Length - 1;



            //string final1 = finalfirstname.ToString();
            // string  final2 = finallastname.ToString();
            Person finalname = new Person(new string(finallastname), sb.ToString());
            return finalname;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(lastname + " ");
            foreach (var fn in firstname)
                sb.Append(fn + " ");
            sb.Length = sb.Length - 1;
            return sb.ToString();
        }

        public int CompareTo(Person other)
        {
            CultureInfo romanian = new CultureInfo("ro-RO");
            StringComparer compare = StringComparer.Create(romanian, true);
            int value = compare.Compare(this.lastname, other.lastname);
            if (value == 0)
            {
                for (int i = 0; i < Math.Min(firstname.Count, other.firstname.Count); i++)
                {
                    int value2 = compare.Compare(firstname.ElementAt(i), other.firstname.ElementAt(i));
                    if (value2 != 0)
                    {
                        return value2;

                    }
                }
                return 0;
            }
            else
                return value;
        }

        public bool Equals(Person other)
        {
            bool last = this.lastname.Equals(other.lastname);
            bool first = CompareFirstnames(this.firstname, other.firstname);
            return last && first;

        }
        public static bool CompareFirstnames(List<string> thisfirstname, List<string> otherfirstname)
        {
            if (thisfirstname.Count != otherfirstname.Count)
                return false;

            for (int i = 0; i < thisfirstname.Count; i++)
            {
                if (thisfirstname[i] != otherfirstname[i])
                    return false;
            }

            return true;
        }
    }
}
