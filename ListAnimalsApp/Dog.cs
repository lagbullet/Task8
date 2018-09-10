using System;

namespace AnimalsApp
{
    class Dog : IAnimal
    {
        private string _Name;
        private int _Age;

        public string Name { get; set; }
        public int Age { get; set; }

        public string Talk()
        {
            return "Woof";
        }

        public void Show()
        {
            Console.WriteLine("Here is a Dog: {0} Age : {1} -- {2}", Name, Age, Talk());
        }

        public Dog(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public Dog() { }
    }
}
