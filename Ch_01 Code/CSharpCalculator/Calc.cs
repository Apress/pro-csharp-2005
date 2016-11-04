using System;

namespace CalculatorExample
{
	public class CalcApp
	{
		static void Main()
		{
			Calc c = new Calc();
			int ans = c.Add(10, 84);
			Console.WriteLine("10 + 84 is {0}.", ans);
            Console.ReadLine();
        }
	}

	public class Calc
    {
		public int Add(int x, int y)
		{
			return x + y;
		}
    }
}
