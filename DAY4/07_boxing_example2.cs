using System;
using static System.Console;

// struct �϶���
// => IComparable �� �����ϸ� ���ڰ� object �̹Ƿ� Boxing �߻� �մϴ�.
// => �̷� ������ �����ϱ� ����
// => IComparable<T> ����

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


