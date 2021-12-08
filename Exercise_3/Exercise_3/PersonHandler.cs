using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class PersonHandler
    {
        public void SetAge(Person person, int age)
        {
            person.Age = age;
        }
        public Person CreatePerson(int age, string fName, string lName, double height, double weight)
        {
            Person person = new Person(fName, lName);
            person.Height = height;
            person.Weight = weight;
            SetAge(person, age);
            return person;
        }
        public int GetAge(Person person)
        {
            return person.Age;
        }
        public string GetFullName(Person person)
        {
            return $"{person.FName} {person.LName}";
        }
    }
}
