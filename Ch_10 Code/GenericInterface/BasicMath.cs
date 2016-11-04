﻿#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace GenericInterface
{
	public interface IBinaryOperations<T>
	{
		T Add(T arg1, T arg2);
		T Subtract(T arg1, T arg2);
		T Multiply(T arg1, T arg2);
		T Divide(T arg1, T arg2);
	}

	public class BasicMath : IBinaryOperations<int>
	{
		public BasicMath() {}

		#region IBinaryOperations<int> Members

		public int Add(int arg1, int arg2)
		{ return arg1 + arg2; }

		public int Subtract(int arg1, int arg2)
		{ return arg1 - arg2; }

		public int Multiply(int arg1, int arg2)
		{ return arg1 * arg2; }

		public int Divide(int arg1, int arg2)
		{ return arg1 / arg2; }

		#endregion
	}
}
