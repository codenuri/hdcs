using static System.Console;

class Date
{
    private int year;
    private int month;
    private int day;

    private static int[] days = { 31, 30, 28, 30, 30, 30, 30, 30, 30, 30, 30, 30 };


    public Date(int y, int m, int d) => (year, month, day) = (y, m, d);

    public int Month
    {
        get { return month; }
        set { if (value >= 1 && value <= 12) month = value; }
    }

    public Date AfterDays(int ds)
    {
        Date d = new Date(year, month, day + ds);
        return d;
    }

    public static int HowManyDays(int m, int y = -1)
    {
        if (m == 2 && y != -1)
        {
            return 29;
        }

        return days[m - 1];
    }

    public Date Tomorrow()
    {
        Date d = new Date(year, month, day + 1); // 잘못된 구현
                                                 // 복습할때 수정해 보세요
        return d;
    }
}

class Program
{
    public static void Main()
    {
        // 내일 날짜를 구하는 Tomorrow() 메소드를 만들고 싶다.
        // => instance method ?
        // => static method ?
        // => "내일" 은 기준일이 필요 하다.
        // => 기준이 되는 객체가 필요 하므로 instance method!

        Date d1 = new Date(2024, 9, 12); // 객체 먼저 만들고
        Date d2 = d1.Tomorrow();


        // 윤년인지 알고 싶다. 
        // => 어떻게 제공할까요 ?
        bool b1 = d1.IsLeapYear();
        bool b2 = Date.IsLeapYear(2026);
    }
}

