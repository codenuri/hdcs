using System.Text;
using static System.Console;

class Program
{
    public static void Main()
    {
        // string은 참조 타입
        string s1 = "abcd";
        string s2 = s1; // s1, s2 는 같은 객체를 가리킴.

        string s3 = s1.Clone(); // s1을 복제한 다른 객체를 생성해 달라.


        // StringBuilder 도 참조 타입
        StringBuilder sb1 = new StringBuilder("abcd");
        StringBuilder sb2 = sb1; // sb1, sb2 같은 객체
        StringBuilder sb3 = sb1.Clone();

        // C# 사용시 "복사본 객체" 가 필요 하면
        // => Clone() 메소드 호출하면 됩니다.
        // => 그런데,!!!! "메소드 이름" 이 동일 함을 보장하기 위해
        // => 인터페이스로 약속.(IClonable)

        IClonable c;
    }
}
