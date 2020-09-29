﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace CSharpExercicesW3Resources
{
	public class Algorithim31_40
	{

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