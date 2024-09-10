
// 아래 한줄은
// C# 8.0 : 에러도 아니고, 경고도 없습니다.
// C# 9.0 이후 : 에러는 아니지만 경고가 있습니다.
string s1 = null;

// C#9.0 이후
// => reference type 도 null 가능/불가능으로 분리하자.
string  s2 = null; // null 불가능 타입
                   // 그런데, null 을 넣어도 에러는 아니고
                   // 경고 처리됩니다.( 과거 코드를 컴파일 지원해야 합니다.)
                   // 단지, 개발자에게 알려주기 위해 사용

string? s3 = null; // null 가능 타입


// 위 기능을 제거하려면 project 파일에서
// <nullable> 을 disable 하면 됩니다.



// 프로그램에서 "name" 은 항상 유효한 값을 가져야 한다.
// => 프로그램의 어디에서도 "name" 을 null 을 가져서는 안된다.
//string name = "kim";



