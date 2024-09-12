// date1.cs
using static System.Console;

class Date
{
    private int year;
    private int month;
    private int day;

    public Date(int y, int m, int d) => (year, month, day) = (y, m, d);

    public int Month
    {
        get { return month; }
        set { if (value >= 1 && value <= 12) month = value; }
    }
    
    Date AfterDays(int ds)
    {
        Date d = new Date(year, month, day + ds);
        return d;
    }
}

class Program
{
    public static void Main()
    {
        Date d1 = new Date(2024, 9, 12);

        // Date 클래스 사용자가 좋아할만한 많은 메소드 제공
        Date d2 = d1.AfterDays(1000);
        
    }
}

