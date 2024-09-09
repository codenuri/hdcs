using static System.Console;

// 초기화되지 않은 변수는 쓰기만 가능.
int n;      // 초기값이 없다
int a = 0;  // 초기값이 있다

a = n;		   // error
WriteLine(n);  // error

n = a;	// ok
a = n;  // ok