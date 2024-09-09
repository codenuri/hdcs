using static System.Console;

class CPoint
{
	public int x;
	public int y;
	public CPoint(int a, int b) { x = a; y = b;}
}
struct SPoint
{
	public int x;
	public int y;
	public SPoint(int a, int b) { x = a; y = b; }	
}

class Program 
{
	public static void Main()
	{
		// 28 page 오른쪽 그림
		// #1. class( reference type)
		CPoint cp1; // reference 만 있음. 객체 생성 안됨
                    // 

        int a = cp1.x;	// error  실제 객체가 없음.
        cp1.x = 2;      // error


		// #2
		SPoint sp1; // value type 인데 new 사용안함
                    // 생성자 호출안됨. 즉, 초기화 안됨

        int b = sp1.x;	// error. 초기화 되지 않은 변수
        sp1.x = 2;		// ok
        int c = sp1.x;	// ok. 윗줄에서 초기화 됨. 


		// #3. 아래 코드는 스택에 만들고 초기화까지 된 코드
        SPoint sp2 = new SPoint(1, 1);
		
		int d = sp2.x;	// ok
		sp2.x = 2;		// ok

	}
}
