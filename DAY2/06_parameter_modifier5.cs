using static System.Console;

class Program
{
	public static void Main()
	{
        // int.Parse : 인자로 받은 문자열을 "정수" 변경해서 반환
		// => 인자를 정수를 변환할수 없으면 "예외"
        int n = int.Parse("Hello");  // 예외 발생(에러)

		// int.TryParse : 반환값은 bool
		//				  결과는 out parameter로
		//				  실패시 예외가 아닌 반환값이 false

		bool b1 = int.TryParse("hello", out int ret1); // b1은 false
        bool b2 = int.TryParse("10", out int ret2); // b2 는 true
													// ret2 에는 10

    }
}