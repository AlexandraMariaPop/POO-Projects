using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasa_Elevi
{
    class Student:IEquatable<Student>,IComparable<Student>
    {
        private string lastname;
        private string firstname;
        private double media;
        public Student(string lastname, string firstname,double media)
        {
            this.lastname = lastname;
            this.firstname = firstname;
            this.media = media;
        }
        public Student(string lastname,string firstname,int nr_note, params int[] note)
        {
            this.lastname = lastname;
            this.firstname = firstname;
            int suma = 0;
            for (int i = 0; i < nr_note; i++)
            {
                suma += note[i];
            }
            this.media = suma / nr_note;
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

        public int CompareTo(Student other)
        {
            if (this.media < other.media)
                return 1;
            if (this.media > other.media)
                return -1;
            else
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
        }

        public bool Equals(Student other)
        {
            bool last = this.lastname.Equals(other.lastname);
            bool first = this.firstname.Equals(other.firstname);
            return last && first;
        }

        public Student Formatname()
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

            Student finalname = new Student(new string(finallastname), new string(finalfirstname),this.media);
            return finalname;
        }
        public override string ToString()
        {
            
            return ($"[{lastname} {firstname}] MEDIA: {media} ");
        }
    }
}
