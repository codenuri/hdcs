int n = 1;

string s1 = "";

// switch 문을 사용해서
// n == 0 이면 s1 = "sun"
// n == 1 이면 s1 = "mon"
// n == 2 이면 s1 = "tue"
// 그외에는 s1 에 "unknown" 이라고 넣어 보세요 ( C와 동일합니다.)

switch( n )
{
    case 0:  s1 = "sun"; break;
    case 1:  s1 = "mon"; break;
    case 2:  s1 = "tue"; break;
    default: s1 = "unknown"; break;
}

// 아래 코드가 위와 완전히 동일한 의미 입니다.
// => switch expression
string s2 = n switch 
            {
                0 => "sun",
                1 => "mon",
                2 => "tue",
                _ => "unknown",  // 생략할수 없다. 반드시 필요
             };

Console.WriteLine($"{s1}, {s2}");

// 1번째 switch : string s1 을 먼저 만들고 사용
// 2번째 switch : string s2 를 만들면서 초기화. 