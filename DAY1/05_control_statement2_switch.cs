using System;

int num = 1;

// switch
// => C���� ���� �����ϰ�,
// => �߰��� ���� ���� ����� �����Ѵ�.
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
	// Ÿ�Ե� ���� ����
	case int: 	 
		Console.WriteLine("int");    
		break;
	case double: 
		Console.WriteLine("double"); 
		break;

	// �ϳ��� switch �� Ÿ�԰� ���� ���ÿ� ���絵 ����
	case "ABCD": 
		Console.WriteLine("3.2");    
		break;
	default:	 
		Console.WriteLine("unknown type"); 
		break;
}
