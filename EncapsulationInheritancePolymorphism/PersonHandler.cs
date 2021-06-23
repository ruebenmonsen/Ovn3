using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritancePolymorphism
{
    class PersonHandler
    {
        public void SetAge(Person person, int age) => person.Age = age;
        public int GetAge(Person person) => person.Age;
        
        
        public void SetHeight(Person person, double height) => person.Height = height;
        public double GetHeight(Person person) => person.Height;
        
        
        public void SetWeight(Person person, double weight) => person.Weight = weight;
        public double GetWeight(Person person) => person.Weight;
        
        
        public void SetLastName(Person person, string lastName) => person.LastName = lastName;
        public string GetLastName(Person person) => person.LastName;
        
        
        public void SetFirstName(Person person, string firstName) => person.FirstName = firstName;
        public string GetFirstName(Person person) => person.LastName;


        public Person CreatePerson(string firstName, string lastName, int age, double height, double weight)
        {
            var person = new Person(firstName, lastName)
            {
                Age = age,
                Height = height,
                Weight = weight
            };
            return person;
        }
    }
}