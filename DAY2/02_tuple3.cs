﻿// 인자로 받는 2개의 정수에 대해서
// 합과, 곱을 반환하고 싶다!!
// => 리턴값이 2개 필요 합니다.
// => 다양한 방법이 있지만 가장 많이 사용하는 방법이 "tuple"
(int, int) AddMul(int a, int b)
{
    return (a + b, a * b);
}

// #1. var 로 받기
var ret = AddMul(3, 2);

Console.WriteLine($"{ret.Item1}, {ret.Item2}");