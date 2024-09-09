// 07_object0.cs
// 25page

// C 언어 : 함수기반 언어 (객체지향 언어 아님)
// 1. int, double 같은 기본 타입을 제공하고
// 2. 특정한 작업을 수행하는 함수를 제공하거나, 사용자가 만들어서 사용.

// C로 만든 GUI
using System.Security.Principal;

int win_no = create_window(... 인자들..); // 윈도우 생성함수 호출
move_window(win_no, 100, 100);            // 특정 작업을 하는
resize_window(win_no, 50, 50);            // 함수 호출


// 객체지향 언어 
// 1. 특정한 작업을 수행하는 타입(클래스)을 제공 하거나
//    사용자가 타입을 만들어서 사용
Window w = new Window();
w.Move(100, 100);
w.Resize(50, 50);

// C++, Python : 함수방식, 클래스(타입)방식 라이브러리 모두 제공

// C#, Java : 모든 것은 타입(클래스, 구조체)로 만들어야 한다.
