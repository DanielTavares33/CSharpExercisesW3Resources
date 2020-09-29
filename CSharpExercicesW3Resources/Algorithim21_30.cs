using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CSharpExercicesW3Resources
{
	public class Algorithim21_30
	{
		/// <summary>
		/// Write a C# Sharp program to create a string like "aababcabcd" from a given string "abcd".
		/// </summary>
		public string Exercicio30(string str)
		{
			var result = string.Empty;

			for (int i = 0; i < str.Length; i++)
			{
				result += str.Substring(0, i + 1);
			}
			return result;
		}

		/// <summary>
		/// Write a C# Sharp program to create a new string made of every other character starting with the first from a given string.
		/// </summary>
		public static string Exercicio29(string str)
		{
			string result = String.Empty;

			for (int i = 0; i < str.Length; i++)
			{
				if (i % 2 == 0) result += str[i];
			}

			return result;
		}

		/// <summary>
		/// Write a C# Sharp program to check if the first appearance of "a" in a given string is immediately followed by another "a".
		/// </summary>
		public static bool Exercicio28(string str)
		{
			var count = 0;
			for (int i = 0; i < str.Length - 1; i++)
			{
				if (str[i].Equals('a'))
				{
					count++;
				}

				if (str.Substring(i, 2).Equals("aa") && count < 2)
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>
		/// Write a C# Sharp program to count the string "aa" in a given string and assume "aaa" contains two "aa"
		/// </summary>
		public static int Exercicio27(string str)
		{
			int count = 0;

			for (int i = 0; i < str.Length - 1; i++)
			{
				if (str.Substring(i, 2) == "aa")
				{
					count++;
				}
			}

			return count;
		}

		/// <summary>
		/// Write a C# Sharp program to create a new string which is n (non-negative integer) copies of the the first 3 characters of a given string. 
		/// If the length of the given string is less than 3 then return n copies of the string.
		/// </summary>
		public static string Exercicio26(string str, int n)
		{
			var result = String.Empty;
			var frontOfString = 3;

			if (frontOfString > str.Length)
				frontOfString = str.Length;

			var front = str.Substring(0, frontOfString);

			for (int i = 0; i < n; i++)
			{
				result += front;
			}

			return result;

			///Solução1
			//string result = String.Empty;

			//for (int i = 0; i < n; i++)
			//{
			//	if (str.Length < 3)
			//	{
			//		result += str;
			//	}
			//	else
			//	{
			//		result += str.Substring(0, 3);
			//	}
			//}
			//return result;
		}

		/// <summary>
		/// Write a C# Sharp program to create a new string which is n (non-negative integer ) copies of a given string.
		/// </summary>
		public static string Exercicio25(string str, int n)
		{
			string result = String.Empty;

			for (int i = 0; i < n; i++)
			{
				result += str;
			}

			return result;
		}

		/// <summary>
		/// Write a C# Sharp program to convert the last 3 characters of a given string in upper case. 
		/// If the length of the string has less than 3 then uppercase all the characters.
		/// </summary>
		public static string Exercicio24(string str)
		{

			return str.Length < 3 ? str.ToUpper() : str.Remove(str.Length - 3) + str.Substring(str.Length - 3).ToUpper();

			///Solução1
			//if (str.Length < 3)
			//{
			//	return str.ToUpper();
			//}
			//else
			//{
			//	return str.Remove(str.Length - 3) + str.Substring(str.Length - 3).ToUpper();
			//}
		}

		/// <summary>
		/// Write a C# Sharp program to check whether two given non-negative integers have the same last digit.
		/// </summary>
		public static bool Exercicio23(int n1, int n2)
		{
			Console.WriteLine(Math.Abs(n1%10));
			Console.WriteLine(Math.Abs(n2%10));
			return Math.Abs(n1 % 10) == Math.Abs(n2 % 10);
		}

		/// <summary>
		/// Write a C# Sharp program to check if a given string contains between 2 and 4 'z' character.
		/// </summary>
		public static bool Exercicio22(string str)
		{
			int cont = 0;

			for (int i = 0; i < str.Length; i++)
			{
				if (str[i] == 'z')
				{
					cont++;
				}
			}

			return cont > 1 && cont < 4;
		}

		/// <summary>
		/// Write a C# Sharp program to find the larger value from two positive integer values that is in the range 20..30 inclusive, 
		/// or return 0 if neither is in that range.
		/// </summary>
		public static int Exercicio21(int n1, int n2)
		{
			if ((n1 >= 20 && n1 <=30) && (n2 >=20 && n2<=30))
			{
				if (n1 > n2)
				{
					return n1;
				}
				else
				{
					return n2;
				}
			}
			else
			{
				return 0;
			}
		}
	}
}
