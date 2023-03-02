using System;

namespace ExplicitStruct
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var explicitMemoryStruct = new ExplicitMemoryStruct();
			explicitMemoryStruct.x = 7;
			explicitMemoryStruct.y = 99;
			explicitMemoryStruct.z = 400;


			Console.WriteLine(explicitMemoryStruct.x);
			Console.ReadLine();






			//int i = 9;
			//object o = i;
			//i = 5;
			//for (int j = 0; j < 999999; j++)
			//{
			//	Console.WriteLine(j + "string");
			//}
			//Console.WriteLine(i + ", " + o); // Console.WriteLine(string.Concat(i.ToString(), ", "));
			//// Console.WriteLine(i + ", " + (int)o);
			//Console.ReadLine();
		}
	}
}











//int i = 7;
//object o = i; //boxing
//int j = (int)o; //unboxing
