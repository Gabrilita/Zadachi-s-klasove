using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ClassFamily
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Kolko hora: ");
                int n = int.Parse(Console.ReadLine());

                Family family = new Family();

                for (int i = 0; i < n; i++)
                {
                    Console.Write("Ime: ");
                    string name = Console.ReadLine();

                    Console.Write("Godini: ");
                    int age = int.Parse(Console.ReadLine());

                    Person person = new Person(name, age);
                    family.AddMember(person);
                }

                Console.WriteLine("Sortirane po azbuchen red:");
                family.AzbuchenRed();
            }
    }
}
