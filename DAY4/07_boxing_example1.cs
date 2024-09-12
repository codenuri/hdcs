using System;
using static System.Console;

class Temperature : IComparable 
{
    private double Value { set; get; } = 0;

    public Temperature(double val) => Value = val;

    // ���ڸ� ������ "object obj = t2" �� �޸� �׸��� �ٽ��Դϴ�.
    // Temperature �� class �̹Ƿ� "Boxing" ���� �����ϴ�
    // => ���� ĳ������ �����һ�, �������� �����ϴ�.
    public int CompareTo(object? obj)
    {
        Temperature t = (Temperature)obj;

        // ���� Value �� double �ε�, 
        // double �� CompareTo �ֽ��ϴ�.
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


