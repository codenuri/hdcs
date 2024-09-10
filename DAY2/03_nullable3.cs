using static System.Console;

int  a1 = 10;
int? n1 = 10;

// #1. int 와  int? 의 호환(대입)
// => 항상 int? 가 "int+bool" 임을 생각하세요

int? n2 = a1; // ok
              //int  a2 = n1; // error. n1 은 nullable 이므로 값이 없을수 있다


// #2. nullable 타입에서 값 꺼내기
//n1 = null;

//int a3 = n1.Value;                // n1 이 null 이면 예외 발생
//int a3 = n1.GetValueOrDefault();  // n1 이 null 이면 디폴트값
                                    // int 의 디폴트 값은 0
//int a3 = n1.GetValueOrDefault(3);  // n1 이 null 이면 3 반환 

int a3 = n1 ?? 3; // 위와 동일
                  // n1 != null 이면 n1.Value
                  // n1 == null 이면 3;

Console.WriteLine(a3);



