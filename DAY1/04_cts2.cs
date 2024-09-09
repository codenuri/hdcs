// C/C++/Java
// primitive type : 언어 자체가 제공하는 기본 타입(int, double)
// user define type : 사용자가 struct 나 class 문법으로 만드는 타입
/*
int n = 0; // n 에는 멤버(멤버함수, 멤버데이타)라는 개념이 없습니다.
//n.멤버;    // 이런 개념이 없습니다.

Point pt;  // 사용자 정의 타입은
pt.x = 10; // 멤버 데이타라는 개념이 있습니다.
*/

// C# : 모든 타입이 struct 나 class 로 만들어져 있습니다.
// => 그래서 모든 타입의 변수(객체)는 멤버(메소드)가 있습니다.
int n = 0;
n.ToString(); // int 타입 변수에도 메소드가 있습니다.
