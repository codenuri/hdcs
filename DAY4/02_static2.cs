using static System.Console;

// 방법 #2

class Car
{
    private int color = 0;
    private int speed = 0;

//  public int cnt = 0;         // instance 필드 : 객체의 속성. 객체당 한개씩 생성
    public static int cnt = 0;  // static   필드 : Car 클래스 자체의 속성
                                //                모든 Car 객체가 공유. 

    public Car() { ++cnt; }

}
class Program
{
    public static void Main()
    {
        Car c1 = new Car();
        Car c2 = new Car();

//      Console.WriteLine($"{c1.cnt}"); // error. static 필드는 클래스이름으로 접근
        Console.WriteLine($"{Car.cnt}"); // ok. 2
    }
}
