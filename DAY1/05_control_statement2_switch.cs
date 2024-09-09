using System;

int num = 1;

// switch
// => C언어와 거의 동일하고,
// => 추가로 아주 좋은 기능을 제공한다.
switch(num)
{
case 0: 
	Console.WriteLine("0"); 
	break;
case 1: 
	Console.WriteLine("1"); 
	break;
default:
	Console.WriteLine("other"); 
	break;
}

object obj = 3.4;

switch(obj)
{
	// 타입도 조사 가능
	case int: 	 
		Console.WriteLine("int");    
		break;
	case double: 
		Console.WriteLine("double"); 
		break;

	// 하나의 switch 로 타입과 값을 동시에 조사도 가능
	case "ABCD": 
		Console.WriteLine("3.2");    
		break;
	default:	 
		Console.WriteLine("unknown type"); 
		break;
}
