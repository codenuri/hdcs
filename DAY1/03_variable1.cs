// #1. Data type
int    n = 0;
double d = 3.4;
char   c = 'A';
string s = "hello";

// #2. var
// => 우변의 표현식으로 좌변의 타입을 결정해 달라.
var v1 = 10;		// int v1 = 10
var v2 = 3.4;		// double v2 = 3.4
var v3 = "hello";	// string v3 = "hello"

// #3. literal
int a1 = 10;		// 10진수
int a2 = 0x10;		// 16진수
int a3 = 0b10;		// 2진수

int a4 = 1000000;	// 큰 값을 사용하는 경우
int a5 = 1_000_000; // 자릿수 표기법 을 사용하면 편리(위코드와 동일)
                    // 정확한 의미 : 정수 리터럴 사이의 _ 는 무시해달라.


