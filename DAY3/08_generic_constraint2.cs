using System;
using static System.Console;

// 129 ����

class Program
{
    public static void Foo<T>(T a) where T : Animal   // reference type �� ����
    {
        T p = new T();
    }

    public static void Main()
    {
        int n = 0;
        Foo(n); // error
    }
}
