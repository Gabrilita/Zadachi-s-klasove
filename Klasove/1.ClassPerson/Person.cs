using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ClassPerson
{
    internal class Person
    {
        public string name;
        public int age;

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

        public void Izhod()
        {
            Console.WriteLine($"{this.name} e na {this.age} godini");
        }
    }
}
