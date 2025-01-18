using Test1task5.Models;
namespace Test1task5;
internal class Program
{
    static void Main(string[] args)
    {
        Cat cat = new Cat("Murziq", 4, "Ivan");
        Bear bear = new Bear("Teddy", 5, "Forest");
        cat.ShowInfo();
        bear.ShowInfo();
    }
}
