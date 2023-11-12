using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Statistika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Broi hora: ");
            int n = int.Parse(Console.ReadLine());

            List<Person> people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Ime: ");
                string name = Console.ReadLine();

                Console.Write("Vuzrast: ");
                int age = int.Parse(Console.ReadLine());

                Person person = new Person(name, age);
                people.Add(person);
            }

            var sort = people.Where(person => person.Age > 30).OrderBy(person => person.Name);

            Console.WriteLine("Sortirani i nad 30:");
            foreach (var person in sort)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
