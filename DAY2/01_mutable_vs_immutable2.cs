using System;
using static System.Console;


string s1 = "AB";
string s2 = s1;

WriteLine($"{s2[0]}"); // 'A'. ok 읽는 코드

// s2[0] = 'X';  // error


// object.ReferenceEquals()
// => 2개의 reference 변수가 같은 객체를 가리키는지 확인할때 사용
bool b1 = object.ReferenceEquals(s1, s2);

WriteLine($"{b1}"); // True

s2 = "XY"; // s2 = new string("XY") 이므로
           // 기존 가리키던 객체의 속성을 변경한 것이 아닌
           // 새로운 객체의 생성

bool b2 = object.ReferenceEquals(s1, s2);

WriteLine($"{b2}"); // False

