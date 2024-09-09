
// casting
double d = 3.4;
//int n1 = d;	// C 언어. ok. 하지만 3.4 가 아닌 3으로 변경되어서 n1에 대입
                // C/C++ 만 가능하다.
                // 하지만, 정말 안좋은 문법. 
                // C#/Java/Swift 등의 최신언어는 모두 에러

int n1 = (int)d; // ok. 명시적 캐스팅 필요. 
                 // C와 동일
