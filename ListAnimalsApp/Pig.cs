using System;

namespace AnimalsApp
{
    class Pig : IAnimal
    {
        private string _Name;
        private int _Age;

        public string Name { get; set; }
        public int Age { get; set; }

        public string Talk()
        {
            return "Sqee";
        }

        public void Show()
        {
            Console.WriteLine("Here is a Pig: {0} Age : {1} -- {2}", Name, Age, Talk());
        }
        
        public Pig(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
