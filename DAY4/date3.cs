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
}

class Program
{
    public static void Main()
    {
        Date d1 = new Date(2024, 9, 12);

        // 5월 달이 몇일까지 있는지 알고 싶다.
        // => 사용자가 어떻게 사용하게 하는 것이 편리할까요 ?

        // 방법 #1. 객체를 만든후 메소드 호출
        Date d2 = new Date(2024, 5, 1);
        int ds1 = d2.HowManyDays();

        // 방법 #2. 클래스이름으로 메소드 호출
        int ds2 = Date.HowManyDays(5);
        

    }
}

