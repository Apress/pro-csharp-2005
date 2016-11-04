using System;

namespace CustomEnumerator
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
