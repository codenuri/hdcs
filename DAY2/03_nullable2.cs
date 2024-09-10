string s = null;
int?   n = null;

// 값이 있는지/없는지 조사하는 방법.
// #1. null 과 비교
if (s == null) { }
if (n == null) { }

// #2. hasValue 속성 조사
// => Nullable<T> 만 가능
// => reference type 은 없음.
bool b1 = n.HasValue;
//bool b2 = s.HasValue; // error
