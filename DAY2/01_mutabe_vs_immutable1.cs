// 30 page
// mutable   : 객체의 속성을 변경할 수 있는 것 
// immutable : 객체의 속성을 변경할 수 없는 것 

// 배열 : mutable 합니다.
int[] x = { 1, 2, 3 };
x[0] = 10; // ok. mutable 하므로 변경 가능.


// string 타입 : immutable 합니다.
string s = "ABC";
s[0] = 'X'; //error. immutable 하므로 변경할수 없습니다.

s = "XY"; // ok  s가 가리키는 문자열을 변경하는 것이 아니라
          // 새로운 문자열 객체 생성
          // s = new string("XY")
           

