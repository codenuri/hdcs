
// top level programming : Main 을 만들지 않는 방식
// => 실제 Main 이 없는 것이 아니라
// => 컴파일러가 추가한것

// top level programming 방식의 한계
// => struct 나 class 만들때 반드시 다른 문장의 아래 부분에 있어야 한다.
// => 이런 제약이 너무 혼란스러울수 있습니다.(숨겨진 코드 때문에..)
// => 그래서, top level 보다는 Main 을 직접 만드는 것이 학습에 도움. 


class Car   // 이위치에 있으면 에러
{
}

Car c = new Car();


class Car // 이 위치는 에러 아님.
{
}