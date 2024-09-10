using static System.Console;
// 35 page

// #1. variable, array, tuple
int n1 = 0;                 // 일반 변수 : 값을 한개만 보관

int[] a1 = { 1, 2, 3 };     // 배열 : 동일 타입을 여러개 보관

(int, double, char) t1 = (3, 4.5, 'A'); // 튜플 : 서로 타입을 여러개 보관

// #2. tuple 만드는 법
//ValueTuple<int, double, char> t2 = new ValueTuple<int, double, char>(3, 4.5, 'A');
                        // => 이 표현이 정확한 표기법이지만
                        // => 복잡하기 때문에 아래 편의 표기법 사용

// (int, double, char) : 타입
// t2                   : 변수이름
(int, double, char) t2 = (3, 4.5, 'A');
