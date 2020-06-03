using System;
using System.Text;
namespace Agenda_Personala
{
    public class Person
    {
        private string firstname;
        private string lastname;
        private string email;
        private int id;
        private int age;
        private long phonenumber;
        public Person()
        {
            this.firstname = "";
            this.lastname = "";
            this.email = "";

        }
        public Person(int id,string lastname,string firstname,int age,long phonenumber,string email)
        {
            this.id = id;
            this.lastname = lastname;
            this.firstname = firstname;
            this.age = age;
            this.phonenumber = phonenumber;
            this.email = email;
        }
       public string FirstName
        {
            get
            {
                return firstname;
            }

            set
            {
                firstname=value;
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
                lastname=value;
            }


        }
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public int Age
        {
            get
            {
                return age;

            }
            set
            {
                age = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }

        }
        public long PhoneNumber
        {
            get
            {
                return phonenumber;
            }
            set
            {
                phonenumber = value;
            }
        }
        public bool Validate()
        {
            return true;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("~");
            sb.Append("ID: "+id + ", ");
            sb.Append("LASTNAME: " + lastname + ", ");
            sb.Append("FIRSTNAME: " + firstname + ", ");
            sb.Append("AGE: "+age + ", ");
            sb.Append("PHONE NUMBER: " +phonenumber + ", ");
            sb.Append("EMAIL: "+email);
            sb.Append("~");
            return sb.ToString();
        }
    }
}