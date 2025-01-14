namespace Test1task4.Models
{
    internal class MyStack
    {
        public int[] stack = new int [50];
        
        public int lastIndex=0;

        public void Push(int value)
        {
            stack[lastIndex] = value;
            lastIndex++;
        }
        public void Pop()
        {
            Console.WriteLine($"Last stack element is {stack[lastIndex-1]}");
        }
    }
}
