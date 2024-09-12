using static System.Console;

// Car 객체를 몇개나 생성했는지 갯수를 파악하고 싶다.

class Car
{
    private int color = 0;
    private int speed = 0;

    public int cnt = 0;

    public Car() { ++cnt; }

}
class Program
{
    public static void Main()
    {
        Car c1 = new Car();
        Car c2 = new Car();

        Console.WriteLine($"{c1.cnt}"); // ??
    }
}
