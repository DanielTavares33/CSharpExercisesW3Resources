using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CSharpExercicesW3Resources
{
	class Algorithim21_30
	{
		static void Main(string[] args)
		{
			Console.WriteLine(Exercicio23(123,456));
			Console.WriteLine(Exercicio23(12, 512));
			Console.WriteLine(Exercicio23(7,87));
			Console.WriteLine(Exercicio23(12, 45));
			Console.ReadLine();
			
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
