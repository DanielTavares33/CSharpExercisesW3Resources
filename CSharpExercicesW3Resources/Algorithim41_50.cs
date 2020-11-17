using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpExercicesW3Resources
{
	class Algorithim41_50
	{

		/// <summary>
		/// Write a C# Sharp program to check if a given number is within 2 of a multiple of 10.
		/// </summary>
		public static bool Exercicio44(int n)
		{
			return n % 10 <= 2 || n % 10 >= 8;
		}

		/// <summary>
		/// Write a C# Sharp program to check if a given non-negative given number is a multiple of 3 or 7, but not both.
		/// </summary>
		public static bool Exercicio43(int n1)
		{
			/// Logical exclusive OR operator 
			return n1 % 3 == 0 ^ n1 % 7 == 0;
		}

		/// <summary>
		/// Write a C# Sharp program to test if a given non-negative number is a multiple of 13 or it is one more than a multiple of 13.
		/// </summary>
		public static bool Exercicio42(int n1)
		{
			return n1 % 13 == 0 || n1 % 13 == 1;
		}

		/// <summary>
		/// Write a C# Sharp program that accept two integers and return true if either one is 5 or their sum or difference is 5.
		/// </summary>
		public static bool Exercicio41(int n1, int n2)
		{

			return n1 == 5 || n2 == 5 || n1 + n2 == 5 || Math.Abs(n1 - n2) == 5;

			//if (n1 == 5 || n2 == 5)
			//{
			//	return true;
			//}
			//else if (n1 + n2 == 5)
			//{
			//	return true;
			//}
			//else if (n1 - n2 == 5)
			//{
			//	return true;
			//}
			//return false;
		}
	}
}
