namespace Test1task5.Models;
internal class Bear : Animal
{
    public string Habitat;

    public Bear(string name, int age, string habitat)
    {
        Name = name;
        Age = age;
        Habitat = habitat;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Bear name: {Name}. Bear age: {Age}. Bear habitat: {Habitat}.");
    }
}
