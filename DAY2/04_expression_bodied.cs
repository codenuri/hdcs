using System;

//46 page 오른쪽
class Program
{
    public static int Square1(int x)
    {
        return x * x;
    }

    // 아래 코드가 위 코드와 동일합니다.
    // => 메소드(함수) 구현시
    // => {} 대신 "=>반환값" 으로 표기
    // => "expression bodied" 라는 이름의 기술. 
    public static int Square2(int x) => x * x;



    public static void Main()
    {
        int ret = Square1(3);
    }
}