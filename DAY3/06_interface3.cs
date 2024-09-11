using System.Text;
using static System.Console;

class Program
{
    public static void Main()
    {
        // string은 참조 타입
        string s1 = "abcd";
        string s2 = s1; // s1, s2 는 같은 객체를 가리킴.

        string s3 = (string)s1.Clone(); // s1을 복제한 다른 객체를 생성해 달라.


        // 배열 도 참조 타입
        int[] x = { 1, 2, 3 };
        int[] y = (int[])(x.Clone());


        // C# 사용시 "복사본 객체" 가 필요 하면
        // => Clone() 메소드 호출하면 됩니다.
        // => 그런데,!!!! "메소드 이름" 이 동일 함을 보장하기 위해
        // => 인터페이스로 약속.(ICloneable)

        ICloneable c;
    }
}
