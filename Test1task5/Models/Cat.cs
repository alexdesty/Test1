namespace Test1task5.Models;
internal class Cat : Animal
{
    public string OwnersName;

    public Cat(string name, int age, string ownersName)
    {
        Name = name;
        Age = age;
        OwnersName = ownersName;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Cat name: {Name}. Cat age: {Age}. Cat owner's name: {OwnersName}.");
    }
}

