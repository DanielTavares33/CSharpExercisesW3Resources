using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpExercicesW3Resources
{
	class Algorithm1_10
	{
		//static void Main(string[] args)
		//{
		//	Console.WriteLine(Exercicio10(3));
		//	Console.WriteLine(Exercicio10(14));
		//	Console.WriteLine(Exercicio10(12));
		//	Console.WriteLine(Exercicio10(37));
		//	Console.ReadLine();
		//}

		// <summary>
		/// Write a C# Sharp program to check if a given positive number is a multiple of 3 or a multiple of 7.
		/// </summary>
		public static bool Exercicio10(int number)
		{
			return number % 3 == 0 || number % 7 == 0;
		}

		// <summary>
		/// Write a C# Sharp program to create a new string with the last char added at the front and back of a given string of length 1 or more.
		/// </summary>
		public static string Exercicio9(string str)
		{
			return str.Length >= 1 ? str.Substring(str.Length - 1, 1) + str + str.Substring(str.Length - 1, 1) : str;
		}

		/// <summary>
		/// Write a C# Sharp program to create a new string which is 4 copies of the 2 front characters of a given string. 
		/// If the given string length is less than 2 return the original string.
		/// </summary>
		public static string Exercicio8(string str)
		{
			return str.Length < 2 ? str : str.Substring(0, 2) + str.Substring(0, 2) + str.Substring(0, 2) + str.Substring(0, 2);
		}

		/// <summary>
		/// Write a C# Sharp program to exchange the first and last characters in a given string and return the new string.
		/// </summary>
		public static string Exercicio7(string s)
		{
			return s.Length > 1 ? s.Substring(s.Length - 1) + s.Substring(1, s.Length - 2) + s.Substring(0, 1) : s;
		}

		/// <summary>
		/// Write a C# Sharp program to remove the character in a given position of a given string. 
		/// The given position will be in the range 0.. string length -1 inclusive.
		/// </summary>
		public static string Exercicio6(string s, int x)
		{
			return s.Remove(x, 1);
		}

		/// <summary>
		/// Write a C# Sharp program to create a new string where 'if' is added to the front of a given string. 
		/// If the string already begins with 'if', return the string unchanged.
		/// </summary>
		public static string Exercicio5(string x)
		{
			if (x.Length > 2 && x.Substring(0, 2).Equals("if"))
			{
				return x;
			}

			return "if " + x;
		}

		/// <summary>
		/// Write a C# Sharp program to check a given integer and return true if it is within 10 of 100 or 200. 
		/// </summary>
		public static bool Exercicio4(int x)
		{
			const int n = 100;
			const int n2 = 200;

			if (Math.Abs(x - n) <= 10 || Math.Abs(x - n2) <= 10)
			{
				return true;
			}

			return false;
		}

		/// <summary>
		/// Write a C# Sharp program to check two given integers, and return true if one of them is 30 or if their sum is 30.
		/// </summary>
		public static bool Exercicio3(int x, int y)
		{
			if (x == 30 || y == 30)
			{
				return true;
			}
			else if (x + y == 30)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// Write a C# Sharp program to get the absolute difference between n and 51. 
		/// If n is greater than 51 return triple the absolute difference.  
		/// </summary>
		public static int Exercicio2(int n)
		{
			const int x = 51;

			if (n > x)
			{
				return (n - x) * 3;
			}

			return x - n;
		}

		/// <summary>
		/// Write a C# Sharp program to compute the sum of the two given integer values. 
		/// If the two values are the same, then return triple their sum.
		/// </summary>
		public static int Exercicio1(int x, int y)
		{
			int result = 0;

			if (x == y)
			{
				result = (x + y) * 3;
			}
			else
			{
				result = x + y;
			}

			return result;
		}

		// Solução do exercicio do teste Bosch
		public static int Solution(int N)
		{

			for (int i = 0; i <= N; i++)
			{

				if (i % 3 == 0 && i % 2 == 0)
				{
					Console.WriteLine("Certo");

				}
				else if (i % 5 == 0)
				{
					Console.WriteLine("Errado");
				}
				else
				{
					Console.WriteLine(i);
				}
			}

			return 0;
		}
	}
}
