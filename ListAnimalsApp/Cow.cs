using System;

namespace AnimalsApp
{
    class Cow : IAnimal
    {
        private string _Name;
        private int _Age;

        public string Name { get; set; }
        public int Age { get; set; }

        public string Talk()
        {
            return "Moo";
        }

        public void Show()
        {
            Console.WriteLine("Here is a Cow: {0} Age : {1} -- {2}", Name, Age, Talk());
        }

        public Cow(string name, int age)
        {
            Name = name;
            Age = age;
        }

    }
}
