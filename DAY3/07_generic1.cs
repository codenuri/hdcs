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

        swap<int>(ref n1, ref n2);		
		swap<double>(ref d1, ref d2);
    }
}