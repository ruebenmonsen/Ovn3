using System;
using System.Collections.Generic;
using System.Linq;

namespace EncapsulationInheritancePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3.1 (Inkapsling)
            PersonHandler personHandler = new();

            Person sven;
            Person olof;
            Person lisa;
            
            try
            {
                sven = personHandler.CreatePerson("Sven", "Andersson", age: 25, height: 180, weight: 80);
                olof = personHandler.CreatePerson("Olof", "Karlsson", age: 60, height: 172, weight: 67);
                lisa = personHandler.CreatePerson("Lisa", "Larsson", age: 47, height: 170, weight: 64);

            }
            catch (ArgumentNullException e1)
            {
                throw new ArgumentNullException(e1.Message);
            }
            catch(ArgumentOutOfRangeException e2)
            {
                throw new ArgumentOutOfRangeException(e2.Message);
            }

            // Testar metoder

            // Sven och Lisa gifter sig
            personHandler.SetLastName(sven, "Larsson");

            List<Person> persons = new List<Person> { sven, olof, lisa };
            
            // Ett år passerar
            foreach (var person in persons)
            {
                var age = personHandler.GetAge(person);
                age++;
                personHandler.SetAge(person, age);
                // person.Age++
            }



            // 3.2 (Arv)
            // Skapar lista som tar emot djur
            List<Animal> animals = new();

            // Skapar några instanser av djur
            var bolt = new Dog
            {
                Name = "Bolt",
                Weight = 10,
                Age = 5,
                HumanFriends = 50
            };

            var wolfy = new Wolf
            {
                Name = "Wolfy",
                Weight = 15,
                Age = 7,
                IsPackLeader = true
            };

            var lillaGubben = new Horse
            {
                Name = "Lilla Gubben",
                Weight = 150,
                Age = 12,
                HorseshoeMaterial = "Aluminium"
            };

            var peter = new Wolfman
            {
                Name = "Peter Stumpp",
                Weight = 90,
                Age = 61,
                IsPackLeader = false
            };


            // Lägger djur i listan
            animals.Add(bolt);
            animals.Add(wolfy);
            animals.Add(lillaGubben);
            animals.Add(peter);


            foreach (var animal in animals)
            {
                Console.WriteLine(animal.GetType().Name);
                
                if (animal is IPerson otherkin)
                {
                    animal.DoSound();
                    otherkin.Talk();
                }
                else
                {
                    animal.DoSound();
                }
                
            }
            //13. F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, i
            // vilken klass bör vi lägga det?
            // I Bird-klassen så alla ärvande klasser kan ärva attributet

            //14.F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
            // I Animal-klassen enligt ovan


            //List<Dog> dogs = new();
            List<Object> dogs = new();
            dogs.Add(lillaGubben);
            dogs.Add(sven);
            dogs.Add(olof);
            //9 F: Försök att lägga till en häst i listan av hundar. Varför fungerar inte det?
            // Det är fel typ

            //10 F: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans
            // För att lagra instanser av alla klasser måste listan vara en lista av objekt.
            // Vi kan då använda antingen klassen Object i sig eller nyckelordet object som typ för listan

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Stats());
            }

            //13 F: Förklara vad det är som händer.
            // Vi har en lista av objekt. Listan är deklarerad som av typ Animal. Vi kan i denna lista ha objekt av typen Animal
            // men också av alla objekt som ärver från Animal, även objekt som Wolfman som ärver från Animal via Wolf.
            // Detta är polymorfismens första regel.
            // I vår iteration anropar vi objektets metod Stats(). Enligt polymorfismens andra regel utnyttjas den mest
            // specialiserade metoden, därför anropas metoderna direkt i objekten (detta har implementerats mha nyckelorden
            // virtual och override. Om metoden inte skulle varit deklarerad i objektet skulle kompilatorn gått upp ett steg i
            // arvsordningen och kollat där osv. tills metoden hittats.
            // Med nyckelordet base har vi här också avsiktligt gjort det för att reducera duplicerad kod.

            foreach (var animal in animals)
            {
                if (animal.GetType() == typeof(Dog))
                    Console.WriteLine(animal.Stats());
            }

            // Kommer du åt den metoden från Animals listan ? F : Varför inte?
            // Nej, metoderna måste vara deklarerade i basklassen Animal för att kunna kallas. Vi har ingen abstrakt eller
            // virtuell metod i basklassen som vi "overridear" vilket skulle krävas i detta fall. Lösningen är att casta.
            
            foreach (var animal in animals)
            {
                if (animal is Dog dog)
                    Console.WriteLine(dog.WaggleTail());


            }

            // 3.4 Klar.
            List<UserError> userErrors = new();

            userErrors.Add(new NumericInputError());
            userErrors.Add(new TextInputError());
            userErrors.Add(new NullInputError());
            userErrors.Add(new IrrationalInputError());
            userErrors.Add(new InfiniteInputError());

            foreach (UserError userErrorInstance in userErrors)
            {
                Console.WriteLine(userErrorInstance.UEMessage());
            }
            //F: Varför är polymorfism viktigt att behärska?
            // Att kunna tillämpa polymorfism ökar programmets flexibilitet och anpassbarhet.

            //F: Hur kan polymorfism förändra och förbättra kod via en bra struktur?
            // Polymorfism möjliggör för en variabel att peka mot olika objekt som ärver från den klass variabeln är
            // deklarerad som. Vi kan använda detta för att minska repeterande kod och för att t.ex. refaktorera
            // variablens tilldelning. Detta kan göra koden mer flexibel och mer överskådlig

            //F: Vad är det för en skillnad på en Abstrakt klass och ett Interface?
            // I en abstrakt klass kan metoder implementeras, i ett interface deklareras de endast (för att sedan kräva
            // implementering i de ärvande klasserna)
        }
    }
}
