class Example
{
    public int Data1 = 0;   // public 필드. 어디서도 접근 가능

    private int Data2 { set; get; } = 0; // property
}

class Program
{
    public static void Main()
    {
        Example e1 = new Example();

        e1.Data1 = 10;
        e2.Data2 = 10;

    }
}
