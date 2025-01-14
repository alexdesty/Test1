using System.Text;

namespace Test1task2.Models;

internal class MyString
{
    public string StringValue { get; set; }

    public MyString() { StringValue = "Default string"; }

    public MyString(string stringValue)
    {
        StringValue = stringValue;
    }

    public void ReverseString(string str)
    {
        var stringBeforeReverse = new StringBuilder(str);
        var reversedString = new StringBuilder(stringBeforeReverse.ToString());
        var index = 0;
        for (var i = stringBeforeReverse.Length - 1; i >= 0; i--)
        {
            reversedString[index] = stringBeforeReverse[i];
            index++;
        }
        Console.WriteLine(reversedString.ToString());
    }
}

