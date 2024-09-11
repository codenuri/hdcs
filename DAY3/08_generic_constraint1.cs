using System;
using static System.Console;

class Program
{
    public static T Max<T>(T a, T b)
    {
        return a.CompareTo(b) < 0 ? b : a;
    }

    public static void Main()
    {
        int n1 = 10, n2 = 20;

        string s1 = "AA", s2 = "BB";

        int ret1 = Max(n1, n2);
        string ret2 = Max(s1, s2);
    }
}
