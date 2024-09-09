using System;

Console.Write("input yout age >> ");


// 문자열이 아닌 "숫자(정수, 실수)" 로 입력 받는 방법
// => 모든 프로그래밍 언어에서 "입력"은 항상 문자열로 하게 됩니다.
// => 입력된 문자열을 정수 또는 실수로 변경해서 사용하게 됩니다.

// C/C++ : 라이브러리의 입출력 함수가 내부적으로 변경해줌
// C#    : 개발자가 해야 한다.

// #1. 문자열로 입력 받으세요
string s = Console.ReadLine(); // "10"
                                // "ab"

// #2. 문자열을 정수로 변경해서 사용
// => "Convert" 라는 클래스의 다양한 static 메소드 사용
// => "int" 라는 타입의 static 메소드 사용
//     (핵심 : C# 은 int 도 메소드가 있습니다.)

//int n1 = Convert.ToInt32(s);    // s를 정수로 변경가능하면 ok
                                // 정수로 변경할수 없다면
                                // 예외 발생
                                // 예외 처리 방법은 3일차.. 
int n1 = int.Parse(s);

Console.WriteLine($"{n1}");




