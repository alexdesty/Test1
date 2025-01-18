namespace Test1task5.Models;
internal class Animal
{
    public string Name;

    public int Age;

    public virtual void ShowInfo()
    {
        Console.WriteLine($"This is animal");
    }
}
