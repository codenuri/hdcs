using System;
using static System.Console;

class Temperature : IComparable 
{
    private double Value { set; get; } = 0;

    public Temperature(double val) => Value = val;

    // 인자를 받을때 "object obj = t2" 의 메모리 그림이 핵심입니다.
    // Temperature 가 class 이므로 "Boxing" 현상 없습니다
    // => 단지 캐스팅이 불편할뿐, 오버헤드는 없습니다.
    public int CompareTo(object? obj)
    {
        Temperature t = (Temperature)obj;

        // 현재 Value 는 double 인데, 
        // double 은 CompareTo 있습니다.
        return Value.CompareTo(t.Value);
    }
}

class Program
{
    public static void Main()
    {
        Temperature t1 = new Temperature(5.5);
        Temperature t2 = new Temperature(3.3);

        Console.WriteLine($"{t1.CompareTo(t2)}");
    }
}


