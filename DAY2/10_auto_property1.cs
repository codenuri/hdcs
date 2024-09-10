// 전형적인 C# 코드
// 1. 데이타(필드)를 private 만들고
// 2. 필드 접근은 "property" 를 만드는 것이 관례 입니다.

class Example
{
    private int data1 = 0;

    public int Data1
    {
        set => data1 = value;
        get => data1;
    }

    // 아래 한줄이 위 코드와 완전히 동일합니다.
    // 1. 필드 자동생성되고
    // 2. getter/setter 의 전형적인 코드(위 코드)를 자동생성

    // "auto implemented property" 라고 합니다.
    public int Data2 { get; set; } = 0;
}

class Program
{
    public static void Main()
    {
        Example e = new Example();
        e.Data1 = 10;
        e.Data2 = 10;
    }
}
