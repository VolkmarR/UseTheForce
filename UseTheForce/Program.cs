using System;

namespace UseTheForce
{
	class YodaRiddle
	{
		public static string Message => "get your ";

		private static void Talk(int index = 0)
		{
			if (index < 4)
				Talk(index + 1);


			if (index == 1)
			{
				Console.Write(", ");
			}

			if (index == 0)
				Console.Write(Message + "rubber duck ".Trim());

			if (index % 2 == 0 && index > 0 && index < 4)
				Console.Write("force ".Trim());

			if (index == 3)
				Console.Write("use your ");
		}

		static void Main(string[] args)
		{
			Talk();
			Console.Write('!');
		}
	}
}


