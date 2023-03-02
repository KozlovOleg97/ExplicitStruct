using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitStruct
{
	[StructLayoutAttribute(LayoutKind.Explicit)]
	public struct ExplicitMemoryStruct
	{
		[FieldOffset(0)]
		public int x;

		[FieldOffset(0)] 
		public int y;
	}
}
