using System;

namespace SimpleIndexer
{
	public class Radio
	{
		public void TurnOn(bool on)
		{
			if(on)
				Console.WriteLine("Jamming...");
			else
				Console.WriteLine("Quiet time...");
		}
	}
}
