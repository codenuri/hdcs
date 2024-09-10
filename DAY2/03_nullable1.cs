// 36 page ~


// #1. reference type 의 변수는 null 이 될수 있습니다.
string s1 = "hello";
string s2 = null;	// 아무 객체도 가리키지 않는다는 의미
                    // C 언어의 null pointer(0) 의미

// #2. value type 의 변수는 null 이 될수 없습니다.
int n1 = 0;         // ok
int n2 = null;	    // error. 


// #3. int 같은 value type 도 값없음을 표현하고 싶었습니다.
// => 그래서 nullable 타입의 제공됩니다.

Nullable<int> n3 = null; // ok. 정확한 표기법
int? n4 = null;          // ok. 편의 표기법(단축 표기법)


// 원리 "int?" 타입은
// => int 값 한개와 bool 값 한개 보관(값 있음/없음 표기)
 
  

