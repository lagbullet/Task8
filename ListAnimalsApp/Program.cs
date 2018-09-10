using System;
using System.Collections.Generic;
using System.Linq;

namespace AnimalsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IAnimal> animals = new List<IAnimal>
            {
                new Sheep("Sheep", 5),
                new Cow("Cow", 3),
                new Dog("Dog", 13),
                new Pig("Pig", 6),
                new Cat("Cat", 17)
            };
            var result = from d in animals
                         where d.Name == "Sheep"
                         select d;
            foreach (var i in result)
            {
                i.Age = 100;
                i.Show();
            }
            Console.ReadKey();
            result = from d in animals
                     where d.Age < 10
                     orderby d.Name ascending
                     select d;
            foreach (var i in result)
                i.Show();
            Console.ReadKey();
            result = from d in animals
                     where d.Name == "Cow"
                     select d;
            var setToRemove = new HashSet<IAnimal>(result);
            animals.RemoveAll(x => setToRemove.Contains(x));
            foreach (var animal in animals)
                animal.Show();
            Console.ReadKey();
        }
    }

}
