using static System.Console;

// 아래 코드 그림이 "29page"

// int : value type

int n1 = 10;
int n2 = n1; // n1, n2 는 다른 메모리

n1 = 20;     // n1만 변경

WriteLine($"{n1} {n2}"); // 20, 10

// 배열 : reference type
// 단, swift 는 배열이 value_type

int[] x1 = {1, 2, 3};
int[] x2 = x1;

x1[0] = 20;
WriteLine($"{x1[0]} {x2[0]}"); //???


// string : reference type 입니다.
string s1 = "AB"; 
string s2 = s1;

s1 = "XY"; // s1 = new string("XY");

WriteLine($"{s1} {s2}");  // "XY", "AB"



// string 변수 선언의 원리
string s3 = "AB"; // string s3 = new string("AB")

s3 = "XY";        // 힙에 있는 객체의 값을 변경하는것이 아니라!!
                  // s3 = new string("XY");  새로 만든것

// 어떨때는 새로운 객체를 만드는 표현이고, 어떨때는 값을 변경하는 코드인가요 ?
// => string 만 조심하세요!
