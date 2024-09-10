class Example
{
    public int Data1 = 0;   // public 필드. 어디서도 접근 가능
                            // R/W 가능

//  public int Data2 { set; get; } = 0; // property
    public int Data2 { get; } = 0; // property
                                    // Read only 또는 write only 도 가능.
                                    
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
