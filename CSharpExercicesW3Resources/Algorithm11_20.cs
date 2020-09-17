using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpExercicesW3Resources
{
	class Algorithm11_20
	{
		static void Main(string[] args)
		{
			Console.WriteLine(Exercicio12("C# Sharp"));
			Console.WriteLine(Exercicio12("C#"));
			Console.WriteLine(Exercicio12("C++"));
			Console.ReadLine();
		}

		/// <summary>
		/// Write a C# Sharp program to check if a given string starts with 'C#' or not
		/// </summary>
		public static bool Exercicio12(string str)
		{
			return (str.Length < 3 && str.Equals("C#") || (str.StartsWith("C#") && str[2] == ' '));
		}

		/// <summary>
		/// Write a C# Sharp program to create a new string taking the first 3 characters of a given string 
		/// and return the string with the 3 characters added at both the front and back. 
		/// If the given string length is less than 3, use whatever characters are there.
		/// </summary>
		public static string Exercicio11(string str)
		{
			if (str.Length < 3)
			{
				return str + str + str;
			}
			else
			{
				string front = str.Substring(0, 3);
				return front + str + front;
			}
		}
	}
}
