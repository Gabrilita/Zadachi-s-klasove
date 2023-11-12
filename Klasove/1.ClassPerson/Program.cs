using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ClassPerson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete ime i godini za 3ma");
            Person obj1 = new Person(Console.ReadLine(), int.Parse(Console.ReadLine()));
            Person obj2 = new Person(Console.ReadLine(), int.Parse(Console.ReadLine()));
            Person obj3 = new Person(Console.ReadLine(), int.Parse(Console.ReadLine()));
            obj1.Izhod();
            obj2.Izhod();
            obj3.Izhod();
        }
    }
}
