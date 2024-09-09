// 변수의 초기값을 지정하는 방법.

int n1;		// 초기화 안됨.

// 아래 2줄은 완전히 동일한 코드 입니다.
// C# 규칙
// => 모든 변수는 "new" 로 만들어야 한다.
// => int, double 등이 표준 타입에 대해서는 "편의 표기법" 제공.
int n2 = 0;         // 아래 코드에 대한 "편의 표기법"
int n3 = new int(); // 정확한 표기법

// C#의 모든 기본 타입은 "디폴트 값" 이 있습니다.(21 p)
// => Generic(template) 이라는 문법 때문에 이런 값이 필요 합니다.

int n4 = default(int); // "int"의 디폴트 값으로 초기화 해달라 0
int n5 = default;	   // 좌변타입이 디폴트 값으로 초기화 해달라 0


var v1 = default(int);  // ok       int v1 = 0
var v2 = default;	    // error    ?   v2 = ?

