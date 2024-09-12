using System;
using static System.Console;

// struct 일때는
// => IComparable 을 구현하면 인자가 object 이므로 Boxing 발생 합니다.
// => 이런 현상을 제거하기 위해
// => IComparable<T> 권장

struct Temperature : IComparable<Temperature>
{
    private double Value { set; get; } = 0;

    public Temperature(double val) => Value = val;

    public int CompareTo(Temperature t)
    {
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


