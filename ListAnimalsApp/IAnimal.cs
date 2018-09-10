namespace AnimalsApp
{
    interface IAnimal
    {
        string Talk();
        string Name { get; set; }
        int Age { get; set; }
        void Show();
    }
}
