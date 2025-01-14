using Test1task2.Models;

namespace Test1task2;
internal class Program
{
    static void Main(string[] args)
    {
        MyString string1 = new MyString("This is string");
        string1.ReverseString(string1.StringValue);
    }
}

