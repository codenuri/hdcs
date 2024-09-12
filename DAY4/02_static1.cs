using static System.Console;

// Car 객체를 몇개나 생성했는지 갯수를 파악하고 싶다.
// => 필드 사용
// => 실패!!!
// => 필드는 객체당 한개씩 따로 사용하게 된다.
// => 아래 코드에서 cnt 는
//    c1, c2 가 각각 따로 가지게 된다.
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

        Console.WriteLine($"{c1.cnt}"); // 1. 
    }
}
