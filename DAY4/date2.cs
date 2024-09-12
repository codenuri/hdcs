// date1.cs
using static System.Console;

class Date
{
    private int year;
    private int month;
    private int day;

    // 월별 날짜 관리(복습시, 아래 날짜수 맞게 작성해 보세요)
    // => 월별 날짜수는 "객체당 한개" 일 필요 없습니다
    // => 날짜 객체가 10개 라도 아래 데이타는 한개면 됩니다.
    // => 핵심 : 아래 데이타는 "static 필드" 이어야 합니다.
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
                            // => 현재는 잘못된 구현
                            // => 복습할때 제대로 구현해 보세요
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

