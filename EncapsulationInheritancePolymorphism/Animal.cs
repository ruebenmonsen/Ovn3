using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritancePolymorphism
{
    public abstract class Animal
    {
        
        public Animal()
        {

        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private int weight;

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        internal abstract void DoSound();

        internal virtual string Stats()
        {
            return $"Name: {Name}. Age: {Age}. Weight: {Weight}.";
        }
    }
}
