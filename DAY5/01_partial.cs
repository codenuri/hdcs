using static System.Console;

// partial class
// => 하나의 클래스를 여러개 파일에 나누어서 작성

// 1. 클래스가 소스가 많아서, 메소드를 기능별로 분리
// 2. 하나의 클래스를 "여러명이 작업" 하거나
//                   "사람 + 기계" 로 작성할때

class Program
{
    public static void Main()
    {
        Car c = new Car();
        c.Color = 10;
        c.Speed = 10;

        c.Go();
        c.Stop();
    }
}


