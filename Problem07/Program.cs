﻿using System;

namespace Problem06
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var input = Console.ReadLine();

			var result = NumberOfWaysToDecode(input, 0);
			Console.WriteLine(result);
		}

		public static int NumberOfWaysToDecode(string message, int index)
		{
			if (index == message.Length)
			{
				return 1;
			}

			var waysToDecode = 0;

			var currentNumber = int.Parse(message[index].ToString());

			if (currentNumber > 0)
			{
				waysToDecode += NumberOfWaysToDecode(message, index + 1);
			}

			if (index < message.Length - 1)
			{
				currentNumber = int.Parse(message.Substring(index, 2));

				if (currentNumber < 27)
				{
					waysToDecode += NumberOfWaysToDecode(message, index + 2);
				}
			}

			return waysToDecode;
		}
	}
}
