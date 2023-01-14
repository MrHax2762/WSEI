using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Osoba
    {
        public String firstName;
        public String lastName;
        public byte age;
        public String title;

        public Osoba(string firstName, string lastName, byte age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public Osoba(string firstName, string lastName, byte age, string title)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.title = title;
        }

        public String ToString()
        {
            return title + " " + firstName + " " + lastName + ": " + age;
        }
    }
}
