// ? 연산자

//string s1 = "abcd";
string s1 = null;

//string s2 = s1.ToUpper(); // 예외 발생
                            // null 객체에 대해서 메소드 호출 안됩니다.


string s2;

// 안전하게 하려면 아래 처럼 합니다.
if ( s1 != null)
{
    s2 = s1.ToUpper();
}

// 아래 한줄이 위와 동일합니다.
s2 = s1?.ToUpper(); // s1 != null 이면  s2 = s1.ToUpper()
                    // s1 == null 이면  s2 = null

// ?? 와 ? 정리
// ?? : null 이면 디폴트값 사용하겠다
// ?  : null 이면 메소드 호출 안하겠다. 그리고 null 반환

int? n = null;
string s = null;

int a = n ?? 3;
string s2 = s?.ToUpper(); 