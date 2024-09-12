using static System.Console;

// 방법 #2

class Car
{
    private int color = 0;
    private int speed = 0;

    private static int cnt = 0;

    public Car() { ++cnt; }

    public int GetCount() {  return cnt; }

}
class Program
{
    public static void Main()
    {
        Car c1 = new Car();
        Car c2 = new Car();

//      Car.cnt = 100; // 이렇게 사용할수 없도록 private 으로

        Console.WriteLine($"{c1.GetCount()}"); 
    }
}
