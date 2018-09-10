using System;

namespace AnimalsApp
{
    class Cat : IAnimal
    {
        private string _Name;
        private int _Age;

        public string Name { get; set; }
        public int Age { get; set; }

        public string Talk()
        {
            return "Meow";
        }

        public void Show()
        {
            Console.WriteLine("Here is a Cat: {0} Age : {1} -- {2}", Name, Age, Talk());
        }

        public Cat(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
