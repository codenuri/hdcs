// date1.cs
using static System.Console;

// 프로그램에서 날짜를 다루는 경우가 많다.
// => Date 라는 타입을 만들자
class Date
{
    private int year;
    private int month;
    private int day;

    public Date(int y, int m, int d) => (year, month, day) = (y, m, d);

    // private 필드에서 대한 속성 제공
    public int Month
    {
        get { return month; }
        set { if (value >= 1 && value <= 12) month = value; }
    }
}

class Program
{
    public static void Main()
    {
        Date d1 = new Date(2024, 9, 12);
        d1.Month = 10;
        WriteLine($"{d1.Month}");
    }
}

