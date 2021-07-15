
using System;


namespace СomputationSin
{
	class Program
	{

		static void Main(string[] args)
		{

			СomputationSinWEps sin = new СomputationSinWEps();
			Console.WriteLine( sin.GetSinValue(1, 1, 1, 0001));
			Console.ReadLine();

		}
	}
	


}
