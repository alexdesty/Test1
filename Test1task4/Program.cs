
using Test1task4.Models;

namespace Test1task4;
    internal class Program
{
    static void Main(string[] args)
    {
        MyStack stack = new MyStack();
        stack.Push(33);
        stack.Pop();
        stack.Push(23);
        stack.Pop();
    }
}
