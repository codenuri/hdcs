using System;
using System.Text;

// string : 값을 변경할수 없는 문자열
// StringBuilder : 값을 변경할수 있는 문자열

// #1. 모든 객체(변수)를 만들때는 "new" 를 사용해야 합니다.
// => 하지만, int, double, string 등 자주 사용하는 타입은 
//    "편의 표기법" 제공

string ss1 = new string("abcd"); // 정확한 표기법
string ss2 = "abcd";             // 편의 표기법

int n1 = new int();
int n2 = 0;

// #2. StringBuilder 라는 타입은 편의 표기법 안됩니다.
StringBuilder sb1 = new StringBuilder("abcd"); // ok
//StringBuilder sb2 = "abcd"; // error


// #3.
// string : immutable
// StringBuilder : mutable

ss1[0] = 'A'; // error
sb1[0] = 'A'; // ok

Console.WriteLine(sb1); // "Abcd"

// 일반적으로 프로그램에서
// "변하지 않은것" 이 항상 빠르고, 안전합니다.

// 따라서, 문자열을 반드시 수정해야 할때만
// "StringBuilder" 사용하고, 그렇지 않으면 "string" 사용하세요