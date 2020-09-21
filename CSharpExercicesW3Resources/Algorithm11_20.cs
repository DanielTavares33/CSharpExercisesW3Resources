using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CSharpExercicesW3Resources
{
	class Algorithm11_20
	{
		static void Main(string[] args)
		{
			Console.WriteLine(Exercicio20(78, 95));
			Console.WriteLine(Exercicio20(25, 35));
			Console.WriteLine(Exercicio20(40, 50));
			Console.WriteLine(Exercicio20(55, 60));
			Console.ReadLine();
		}

		/// <summary>
		/// Write a C# Sharp program to check whether two given integers are in the range 40..50 inclusive, 
		/// or they are both in the range 50..60 inclusive.
		/// </summary>
		public static bool Exercicio20(int n1, int n2)
		{
			return (n1 >= 40 && n2 <= 50 && n2 >= 40 && n1 <= 50) || (n1 >= 50 && n2 <= 60 && n2 >= 50 && n1 <= 60);
		}

		/// <summary>
		///  Write a C# Sharp program to check which number nearest to the value 100 among two given integers. 
		///  Return 0 if the two numbers are equal.
		/// </summary>
		public static int Exercicio19(int n1, int n2)
		{
			/// Solução 2
			const int n = 100;
			var val = Math.Abs(n1 - n);
			var val2 = Math.Abs(n2 - n);


			// se a condicao val == val2 for verdadeira retorna 0, caso contrário se a condicao val < val2 for verdadeira retorna n1 se não retorna n2
			return val == val2 ? 0 : (val < val2 ? n1 : n2);


			/// Solucao1
			//var diff1 = 100 - n1;
			//var diff2 = 100 - n2;

			//if (diff1 < diff2)
			//{
			//	return n1;
			//}
			//else if (n1 == n2)
			//{
			//	return 0;
			//}
			//else
			//{
			//	return n2;
			//}
		}

		/// <summary>
		/// Write a C# Sharp program to check the largest number among three given integers.
		/// </summary>
		public static int Exercicio18(int n1, int n2, int n3)
		{
			var max = Math.Max(n1, Math.Max(n2, n3));
			return max;
		}

		/// <summary>
		/// Write a C# Sharp program to check if a string 'yt' appears at index 1 in a given string. 
		/// If it appears return a string without 'yt' otherwise return the original string.
		/// </summary>
		public static string Exercicio17(string str)
		{
			if (str.Substring(1, 2).Equals("yt"))
			{
				return str.Remove(1, 2);
			}

			return str;
		}

		/// <summary>
		/// Write a C# Sharp program to check whether two given integer values are in the range 20..50 inclusive. 
		/// Return true if 1 or other is in the said range otherwise false.
		/// </summary>
		public static bool Exercicio16(int n1, int n2)
		{
			return (n1 <= 20 || n2 >= 50) || (n2 <= 20 || n1 >= 50);
		}

		/// <summary>
		/// Write a C# Sharp program to check whether three given integer values are in the range 20..50 inclusive. 
		/// Return true if 1 or more of them are in the said range otherwise false.
		/// </summary>
		public static bool Exercicio15(int n1, int n2, int n3)
		{
			if (n1 >= 20 && n1 <= 50 || n2 >= 20 && n2 <= 50 || n3 >= 20 && n3 <= 50)
			{
				return true;
			}

			return false;
		}

		/// <summary>
		/// Write a C# Sharp program to check two given integers whether either of them is in the range 100..200 inclusive.
		/// </summary>
		public static bool Exercicio14(int n1, int n2)
		{
			if (n1 >= 100 && n1 <= 200)
			{
				return true;
			}
			else if (n2 >= 100 && n2 <= 200)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// Write a C# Sharp program to check if one given temperatures is less than 0 and the other is greater than 100.
		/// </summary>
		public static bool Exercicio13(int temp1, int temp2)
		{
			// Solution 1
			if (temp1 < 0 && temp2 > 100)
			{
				return true;
			}
			else if (temp2 < 0 && temp1 > 100)
			{
				return true;
			}
			else
			{
				return false;
			}

			// Solution 2
			//return temp1 < 0 && temp2 > 100 || temp2 < 0 && temp1 > 100;
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
