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

			Console.WriteLine(explicitMemoryStruct.x);
			Console.ReadLine();
		}
	}
}
