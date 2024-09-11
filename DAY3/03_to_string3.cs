using System.Collections;
using static System.Console;

class Program
{
    public static void Main()
    {
        List<int> s = new List<int>();

        s.Add(1);
        s.Add(2);
        s.Add(3);

        // s.ToString() : s객체의 상태 정보를 문자열로 반환
        //          1. s의 클래스 이름을 반환
        //          2. [1,2,3] 이라는 데이타를 알고 싶다. 
        //          => 보통 2번을 원하게 됩니다.
        //          => 그렇게 동작하려면 List 를 만들때 "ToString()" 을
        //              override 해야 하는데.
        //              하지 않아서, 아래 코드는 클래스 이름 출력. 
        
        WriteLine( s.ToString() );

        

    }
    
}