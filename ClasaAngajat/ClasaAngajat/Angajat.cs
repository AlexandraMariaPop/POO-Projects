using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasaAngajat
{
    class Angajat: IEquatable<Angajat>,IComparable<Angajat>
    {
        private string firstname;
        private string lastname;
        private DateTime date;
        private Angajat angajat;

        public Angajat(Angajat angajat)
        {
            this.angajat = angajat;
        }

        public Angajat(string lastname, string firstname, DateTime date)
        {
            this.lastname = lastname;
            this.firstname = firstname;
            this.date = date;
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
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }
        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }
        public int CompareTo(Angajat other)
        {
            
            CultureInfo romanian = new CultureInfo("ro-RO");
            StringComparer compare = StringComparer.Create(romanian, true);
            int value = compare.Compare(this.lastname, other.lastname);
            if (value == 0)
            {

                int value2 = compare.Compare(this.firstname, other.firstname);
                if (value2 != 0)
                {
                    return value2;

                }

                return 0;
            }
            else
                return value;
        }

        public bool Equals(Angajat other)
        {
            bool last = this.lastname.Equals(other.lastname);
            bool first = this.firstname.Equals(other.firstname);
            return last && first;
        }
        public Angajat formatname()
        {
            string initiallastname = this.lastname;
            char[] finallastname = initiallastname.ToCharArray();
            finallastname[0] = char.ToUpper(finallastname[0]);
            for (int i = 1; i < finallastname.Length; i++)
            {
                finallastname[i] = char.ToLower(finallastname[i]);
            }
            string initialfirstname = this.firstname;
            char[] finalfirstname = initialfirstname.ToCharArray();
            finalfirstname[0] = char.ToUpper(finalfirstname[0]);
            for (int i = 1; i < finalfirstname.Length; i++)
            {
                finalfirstname[i] = char.ToLower(finalfirstname[i]);
            }

            Angajat finalname = new Angajat(new string(finallastname), new string(finalfirstname), this.date);
            return finalname;
        }
        public override string ToString()
        {
             return ($"[{this.lastname} {this.firstname}] Data angajarii: {this.date.Year}, {this.date.Month}, {this.date.Day}"); 
        }
    }
}
