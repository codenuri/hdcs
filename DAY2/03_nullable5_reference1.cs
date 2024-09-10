string s1 = "hello";
string s2 = null;

// #1. null 을 가진 객체의 메소드나 속성을 접근하는 것은 에러(예외 발생)
var ret1 = s1.Length; // ok
var ret2 = s2.Length; // runtime error. 예외 발생


// #2. value type 은 null 을 허용할지/말지 선택 가능합니다.
int  n1 = 10;       // null 이 될수 없는 타입
int? n2 = null;     // null 이 될수 있는 타입


// #3. reference type 은 항상 null 이 가능합니다.
// => 선택할수 있었다면 좋지 않을까 ?
// => 그래서 C# 9.0 부터 nullable reference 개념 등장
string s3 = null;
string? s4 = null; // C# 9.0 


