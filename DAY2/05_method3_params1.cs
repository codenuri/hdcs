class Program
{
    public static void M1(int a, int b) { }

    // 인자로 배열을 사용하면 가변인자로 전달 가능 합니다.
    public static void M2(int[] arr) { }

    // params : 인자의 갯수를 가변으로 받겠다...
    // => 정확한 의미는 
    // => 배열로 인자를 받겠다..
    // => 그런데 M3(1,2,3) 형식을 허용해 달라.
    public static void M3(params int[] arr) { }

    public static void Main()
    {
        M1(1, 2);

        M2( new int[] { 1, 2, 3 } ); // ok
        M2( new [] { 1, 2, 3 });     // ok

        M2( 1, 2, 3 ); // error

        M3(1, 2, 3); // ok
                     // 1) 1, 2, 3 의 코드를 컴파일러가 "new int[]{1,2,3}" 으로 변경

        M3(1, 2, 3, 4, 5); // "new int[]{1,2,3,4,5}"
    }

    // 주의 사항
    // 1. params 없이 배열인자로 받으면, 뒤에 다른 인자 가능하지만
    // 2. params 인자는 항상 마지막에 있어야 합니다.
    //  public static void M4(int[] ar, int n) { }		     // ok	
    //  public static void M5(params int[] ar, int n) { }	 // error
    //  public static void M6(int n, params int[] ar) { }	 // ok

    // M4 는 반드시 배열형태로 보내므로 헷갈리지 않습니다.
    // M4( new int[]{1,2,3}, 4);
    // M5( 1,2,3,4); // error
    // M6(1,2,3,4);

}
