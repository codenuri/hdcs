// 126
class Program
{
    /*
    public static void swap(ref int a, ref int b)
    {
        int tmp = a;
        a = b;
        b = tmp;
    }

    public static void swap(ref double a, ref double b)
    {
        double tmp = a;
        a = b;
        b = tmp;
    }
    */
    // 위 2개의 swap 은 타입만 다를뿐 구현이 거의 동일합니다.
    // 이경우에는 여러개 swap 메소드를 만들지 말고
    // => "메소드를 만드는 틀" 을 만들면 됩니다.
    public static void swap<T>(ref T a, ref T b)
    {
        T tmp = a;
        a = b;
        b = tmp;
    }

    public static void Main()
    {
        int n1 = 10,  n2 = 20;
        double d1 = 1.1, d2 = 2.3;

        swap<int>(ref n1, ref n2);	// 1. swap(ref int, ref int) 버전의 함수 생성
                                    // 2. 그리고, 이 위치는 call swap(int, int) 로 변경
		swap<double>(ref d1, ref d2); // 1. swap(ref double, ref double) 버전함수 생성
                                      // 2. call swap(doube) 버전

        // 위 코드가 정확한 코드지만
        // => 타입 인자를 생략해도 됩니다.
        // => 타입 인자 생략시, 함수 인자를 보고 타입 추론됩니다.
        swap(ref n1, ref n2);
        swap(ref d1, ref d2);
    }
}