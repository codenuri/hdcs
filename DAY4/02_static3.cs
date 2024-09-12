using static System.Console;

// 방법 #2

class Car
{
    private int color = 0;
    private int speed = 0;

    private static int cnt = 0;

    public Car() { ++cnt; }

//  public int GetCount() {  return cnt; }      // instance method 
                                                // 객체가 있어야만 호출 가능하다.
                                                // 객체와 관련있는 메소드!!

    public static int GetCount() { return cnt; }    // static method
                                                    // 객체 없이 호출 가능.
                                                    // 특정 객체(자동차)와는 관련없는
                                                    // 기능 수행
                                                    // "Car.GetCount()" 로 호출
}
class Program
{
    public static void Main()
    {
        // 이 위치에서 자동차의 갯수를 알고 싶다.
        Console.WriteLine($"{Car.GetCount()}");

        Car c1 = new Car();
        Car c2 = new Car();

//      Car.cnt = 100; // 이렇게 사용할수 없도록 private 으로

        Console.WriteLine($"{Car.GetCount()}"); 
    }
}

// static field
// => 객체와 상관없는 데이타
// => 모든 객체가 공유 하고
// => 객체가 없어도 메모리에 존재


// static method
// => 객체 없이 호출하는 메소드
// => "클래스이름.메소드이름" 형태로 호출.