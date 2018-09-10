using System;

namespace AnimalsApp
{
    class Sheep : IAnimal
    {
        private string _Name;
        private int _Age;

        public string Name { get; set; }
        public int Age { get; set; }

        public string Talk()
        {
            return "Beee";
        }

        public void Show()
        {
            Console.WriteLine("Here is a Sheep: {0} Age : {1} -- {2}", Name, Age, Talk());
        }

        public Sheep(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
