using static System.Console;

int  a1 = 10;
int? n1 = 10;

// #1. int 와  int? 의 호환(대입)
// => 항상 int? 가 "int+bool" 임을 생각하세요

int? n2 = a1; // ok
//int  a2 = n1; // error. n1 은 nullable 이므로 값이 없을수 있다

// #2. nullable 타입에서 값 꺼내기
int a3 = n1.Value;


Console.WriteLine(a3);



