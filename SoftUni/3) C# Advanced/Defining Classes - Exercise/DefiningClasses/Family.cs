using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> people;

        public Family()
        {
            people = new List<Person>();
        }
        public List<Person> People
        {
            get => people;
            set => people = value;
        }

        public void AddMember(Person person)
        {
            people.Add(person);
        }

        public string GetOldestMember()
        {
            people = people.OrderByDescending(p => p.Age).ToList();

            return $"{people[0].Name} {people[0].Age}";
        }

        public void PrintMembersOver30s()
        {
            people = people
                .Where(x => x.Age > 30)
                .OrderBy(x => x.Name)
                .ToList();

            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
