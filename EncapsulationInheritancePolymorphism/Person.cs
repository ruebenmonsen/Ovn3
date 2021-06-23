using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritancePolymorphism
{
    class Person
    {
        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        private int age;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Ålder måste vara större än 0.");
                else
                    age = value;
            }
        }
        private string firstName;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (value.Length < 2 || value.Length > 10)
                    throw new ArgumentException("Förnamn måste vara mellan 2 och 10 bokstäver.");
                else
                    firstName = value;
            }
        }
        private string lastName;

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (value.Length < 3 || value.Length > 15)
                    throw new ArgumentException("Efternamn måste vara mellan 3 och 15 bokstäver.");
                else
                    lastName = value;
            }
        }
        private double height;

        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        private double weight;

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
    }
}
