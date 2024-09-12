using System;

// 이미 C# 에는 "Math" 클래스가 있습니다.
// => 모든 메소드가 "static method" 입니다.

using static System.Math; // Math 클래스 안에 있는
                          // 모든 static method 를 
                          // Math 라는 클래스 이름 없이 사용하겠다.

class Program
{
    public static void Main()
    {
        double d1 = Math.Sqrt(3);
        double d2 = Math.Cos(3.4);

        double d3 = Cos(3.4);
    }
}
/*
namspace AA
{
    class K { }
    namespace BB
    {
    class K { }
    }
}
*/