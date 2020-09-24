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
			Console.WriteLine(Exercicio21(78, 95));
			Console.WriteLine(Exercicio21(20, 30));
			Console.WriteLine(Exercicio21(21, 25));
			Console.WriteLine(Exercicio21(28, 28));
			Console.ReadLine();
			
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
