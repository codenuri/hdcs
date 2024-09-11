using System;

// 107 page

class Point 
{
	private int x = 0;
	private int y = 0;
	public Point(int a, int b) => (x, y) = (a, b);
}

class Program
{
	public static void Main() 
	{
		// p1, p2 는 "동일 객체" 를 가리킵니다.
		// => 객체가 동일
		Point p1 = new Point(1,2);
		Point p2 = p1;

		// p3, p4 는 "동일 객체"는 아니지만
		// => 상태가 동일
		Point p3 = new Point(1,2);
		Point p4 = new Point(1,2);

		// 객체지향 프로그램에서 "equal" 을 이야기할때
		// => 동일 객체인지 ?
		// => 객체의 상태가 동일한지 ? 를 잘 구별하세요.
	}
}
