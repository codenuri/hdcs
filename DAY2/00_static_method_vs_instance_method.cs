// github.com/codenuri/hdcs 에서 "DAY2.zip" 받으시면 됩니다.

// #1. 타입 vs 객체
int n = 10; // int : 타입
            // n   : 변수(객체)


// #2. 타입은 한개지만 객체(변수)는 여러개 만들수 있습니다.
int a1 = 10;
int a2 = 20;


// instance method : 객체(변수)이름으로 호출하는 메소드
//                   객체의 데이타와 연관된 기능을 수행
//                   
// static   method : 타입의 이름으로 호출하는 메소드
//                   특정 객체(변수)의 데이타와는 관련없는 기능수행

int n1 = 10;
int n2 = 20;

string s1 = n1.ToString(); // "변수(객체이름).메소드이름" 인스턴스 메소드
string s2 = n2.ToString(); // n2 의 값 20 을 문자열로 변경해 달라.
                            // n1, n2 가 가진 데이타를 사용하는 메소드


string s = "10";
int ret1 = int.Parse(s); // 객체이름이 아닌 "타입이름.메소드이름"
                         // static 메소드
                         // 인자로 전달된 문자열을 "정수"로 변경하는 일 수행

// Console : 클래스 이름
// 따라서, WriteLine 은 static 메소드 입니다.
Console.WriteLine("hello");
