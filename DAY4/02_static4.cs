using static System.Console;

// 다음중 에러를 모두 고르세요
class Car
{
    private int color = 0;
    private static int cnt = 0;

    public Car M1()     
    {
        color = 0;      // 1
        cnt = 0;        // 2
        return this;    // 3
    }
    public static Car M2()
    {
        color = 0;      // 1
        cnt = 0;        // 2
        return this;    // 3
    }
}

class Program
{
    public static void Main()
    {
        Car.M2();
    }
}
