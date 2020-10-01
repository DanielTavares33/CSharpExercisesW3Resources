using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace CSharpExercicesW3Resources
{
	public class Algorithim31_40
	{
		/// <summary>
		/// Write a C# Sharp program to compute the sum of the two given integers. If the sum is in the range 10..20 inclusive return 30.
		/// </summary>
		public static int Exercicio40(int n1, int n2)
		{
			int sum = n1 + n2;

			return sum >= 10 && sum <= 20 ? 30 : sum;
		}

		/// <summary>
		/// Write a C# Sharp program to check if a triple is presents in an array of integers or not. 
		/// If a value appears three times in a row in an array it is called a triple.
		/// </summary>
		public static bool Exercicio39(int[] numbers)
		{
			int n = 0;

			for (int i = 0; i < numbers.Length - 1; i++)
			{
				n = numbers[i];
				if (n == numbers[i + 1] && n == numbers[i + 2])
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>
		/// Write a C# Sharp program to count the number of two 5's are next to each other in an array of integers. 
		/// Also count the situation where the second 5 is actually a 6.
		/// </summary>
		public static int Exercicio38(int[] numbers)
		{
			int count = 0;

			for (int i = 0; i < numbers.Length - 1; i++)
			{
				if (numbers[i] == 5 && (numbers[i + 1] == 5 || numbers[i + 1] == 6))
				{
					count++;
				}
			}
			return count;
		}

		/// <summary>
		///  Write a C# Sharp program to create a new string of the characters at indexes 0,1, 4,5, 8,9 ... from a given string.
		/// </summary>
		public static string Exercicio37(string str)
		{
			int[] positions = { 0, 1, 4, 5, 8, 9 };

			StringBuilder stringBuilder = new StringBuilder();

			foreach (int item in positions)
			{
				if (item > str.Length - 1) break;

				stringBuilder.Append(str.Substring(item, 1));
			}

			return stringBuilder.ToString();

			//string result = string.Empty;

			//for (int i = 0; i < str.Length; i += 4)
			//{
			//	var c = i + 2;
			//	var n = 0;

			//	n += c > str.Length ? 1 : 2;
			//	result += str.Substring(i, n);
			//}

			//return result;
		}

		/// <summary>
		/// Write a C# Sharp program to create a new string from a give string where a specified 
		/// character have been removed except starting and ending position of the given string.
		/// </summary>
		public static string Exercicio36(string str1, string str2)
		{
			for (int i = str1.Length - 2; i > 0 ; i--)
			{
				if (str1[i] == str2[0])
				{
					str1 = str1.Remove(i, 1);
				}
			}
			return str1;
		}

		/// <summary>
		/// Write a C# Sharp program to compare two given strings and return the number of the positions where they contain the same length 2 substring. 
		/// </summary>
		public static int Exercicio35(string str1, string str2)
		{
			var count = 0;

			for (int i = 0; i < str1.Length - 1; i++)
			{
				for (int z = 0; z < str2.Length - 1; z++)
				{
					if (str1.Substring(i, 2) == str2.Substring(z, 2))
					{
						count++;
					}
				}
			}
			return count;
		}

		/// <summary>
		/// Write a C# Sharp program to check whether the sequence of numbers 1, 2, 3 appears in a given array of integers somewhere.
		/// </summary>
		public static bool Exercicio34(int[] numbers)
		{
			for (var i = 0; i < numbers.Length - 2; i++)
			{
				if (numbers[i] == 1 && numbers[i + 1] == 2 && numbers[i + 2] == 3)
					return true;
			}
			return false;
		}

		/// <summary>
		/// Write a C# Sharp program to check if one of the first 4 elements in an array of integers is equal to a given element. 
		/// </summary>
		public static bool Exercicio33(int[] numbers, int n)
		{
			/// Se o numero de elementos no array for menor que 4, verifica se no array está presente o numero.
			/// Caso contrário pega nos primeiros 4 elementos do array e verifica se o numero está presente.
			return numbers.Length < 4 ? numbers.Contains(n) : numbers.Take(4).Contains(n);
		}

		/// <summary>
		/// Write a C# Sharp program to check a specified number is present in a given array of integers.
		/// </summary>
		public static bool Exercicio32(int[] numbers, int n)
		{
			if (numbers.Contains(n))
				return true;

			return false;

			///Solução1
			//foreach (var number in numbers)
			//{
			//	if (number == n)
			//	{
			//		return true;
			//	}
			//}
			//return false;
		}

		/// <summary>
		/// Write a C# Sharp program to count a substring of length 2 appears in a given string and also as the last 2 characters of the string. 
		/// Do not count the end substring.
		/// </summary>
		public static int Exercicio31(string str)
		{
			var count = 0;
			var last_two_char = str.Substring(str.Length - 2);

			for (int i = 0; i < str.Length - 2; i++)
			{
				if (str.Substring(i, 2).Equals(last_two_char))
				{
					count++;
				}
			}

			return count;
		}
	}
}
