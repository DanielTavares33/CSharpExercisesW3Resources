using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpExercicesW3Resources
{
	class Algorithim41_50
	{
		/// <summary>
		/// Write a C# Sharp program to check if two or more non-negative given integers have the same rightmost digit.
		/// </summary>
		public static bool Exercicio50(int n1, int n2, int n3)
		{
			return n1 % 10 == n2 % 10 || n1 % 10 == n3 % 10 || n2 % 10 == n3 % 10;
		}

		/// <summary>
		/// Write a C# Sharp program to check if three given numbers are in strict increasing order, such as 4 7 15, or 45, 56, 67, but not 4 ,5, 8 or 6, 6, 8. 
		/// However,if a fourth parameter is true, equality is allowed, such as 6, 6, 8 or 7, 7, 7.
		/// </summary>
		public static bool Exercicio49(int n1, int n2, int n3, bool x)
		{
			return x ? n1 <= n2 && n2 <= n3 : n1 < n2 && n2 < n3;
		}

		/// <summary>
		/// Write a C# Sharp program to check if y is greater than x, and z is greater than y from three given integers x,y,z.
		/// </summary>
		public static bool Exercicio48(int x, int y, int z)
		{
			return y > x && z > y;
		}

		/// <summary>
		/// Write a C# Sharp program to check if it is possible to add two integers to get the third integer from three given integers.
		/// </summary>
		public static bool Exercicio47(int n1, int n2, int n3)
		{
			return n1 == n2 + n3 || n2 == n1 + n3 || n3 == n1 + n2;
		}

		/// <summary>
		/// Write a C# Sharp program to check whether a given string starts with "F" or ends with "B". If the string starts with "F" return "Fizz" 
		/// and return "Buzz" if it ends with "B" If the string starts with "F" and ends with "B" return "FizzBuzz". 
		/// In other cases return the original string
		/// </summary>
		public static string Exercicio46(string str)
		{
			if (str.StartsWith("F"))
			{
				return "Fizz";
			}
			else if (str.EndsWith("B"))
			{
				return "Buzz";
			}
			else if (str.StartsWith("F") && str.EndsWith("B"))
			{
				return "FizzBuzz";
			}

			return str;
		}

		/// <summary>
		/// Write a C# Sharp program to compute the sum of the two given integers. If one of the given integer value is in the range 10..20 inclusive return 18.
		/// </summary>
		public static int Exercicio45(int n1, int n2)
		{
			return (n1 >= 10 && n1 <= 20) || (n2 >= 10 && n2 <= 20) ? 18 : n1 + n2;
		}

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
