using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ClassFamily
{
    internal class Family
    {
        private List<Person> members = new List<Person>();

        public void AddMember(Person person)
        {
            members.Add(person);
        }

        public void AzbuchenRed()
        {
            var sortiraniChlenove = members.OrderBy(person => person.Name);
            foreach (var person in sortiraniChlenove)
            {
                Console.WriteLine(person);
            }
        }
    }
}
