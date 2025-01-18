namespace Test1task3.Extensions;

public static class DateTimeExtension
{
    public static void DateFromCreationOfTheWorld(this DateTime value)
    {
        Console.WriteLine($"День {value.Day} месяца {(month)value.Month - 1} года {value.Year + 5508} от сотворения мира");
    }

    enum month
    {
        января,
        февраля,
        марта,
        апреля,
        мая,
        июня,
        июля,
        августа,
        сентября,
        октября,
        ноября,
        декабря
    };
}

