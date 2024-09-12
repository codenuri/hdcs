using static System.Console;

// 다음중 에러를 모두 고르세요
// static field  : 객체가 없어도 메모리에 있다. 모든 객체는 공유
// static method : 객체없이 호출 가능. 
class Car
{
    private int color = 0;
    private static int cnt = 0;

    public Car M1()     
    {
        // M1 이 호출되었다는 것은. 이미 객체가 있다는것
        color = 0;      // 1 ok
        cnt = 0;        // 2 ok 
        return this;    // 3 ok 
    }
  
    public static Car M2()
    {
        // 이 메소드는 객체없이 호출가능. 
        color = 0;      // 1. error. color 는 객체가 있어야 메모리에 있다.
        cnt = 0;        // 2. ok     cnt 는 객체가 없어도 메모리에 있다.
        return this;    // 3. error. this 는 객체가 있어야만 존재하는 것. 
    }
}

class Program
{
    public static void Main()
    {
        Car.M2();

        Car c = new Car();
        c.M1(); // M1(c)
    }
}

// 핵심 : static 메소드에서는
//        static 필드만 접근할수 있다