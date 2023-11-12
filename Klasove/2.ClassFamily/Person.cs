using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ClassFamily
{
    internal class Person
    {
        private string name;
        private int age;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;

        }

        public override string ToString()
        {
            return $"{Name} e na {Age} godini";
        }

    }
}
