using static System.Console;

class Program
{    
    public static void Main()
    {
        // intern pool
        // => C# 에서 읽기 전용 문자열을 관리하는 메모리

        string s = "abcd"; // intern pool 에 있는 객체를 
                            // 가리키게 됩니다.

        // string 클래스는 아래 2줄에 약간의 차이가 있습니다.
        string s1 = "abcd"; // intern pool 
                            // s, s1 은 같은 객체

        string s2 = new string("abcd");
                            // intern pool 이 아닌 새로운 객체 생성

        WriteLine($"{object.ReferenceEquals(s, s1)}");
        WriteLine($"{object.ReferenceEquals(s, s2)}");

    }
}