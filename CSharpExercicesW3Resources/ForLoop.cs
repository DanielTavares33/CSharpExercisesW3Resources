using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpExercicesW3Resources
{
	/// <summary>
	/// Black Josh - Paul Scholes
	/// </summary>
	public class ForLoop
	{
		/// <summary>
		/// Write a program in C# Sharp to display the pattern like right angle triangle with a number.
		/// </summary>
		public static void Exercicio10()
		{
			for(int i = 1; i <= 4; i++)
			{
				for (int j = 1; j <= i; j++)
				{
					Console.Write(j);
				}
				Console.Write("\n");
			}
		}

		/// <summary>
		/// Write a program in C# Sharp to display the pattern like right angle triangle using an asterisk.
		/// </summary>
		public static void Exercicio9()
		{
			for (int i = 1; i <= 4; i++)
			{
				for (int j = 1; j <= i; j++)
				{
					Console.Write("*");
				}
				Console.Write("\n");
			}
		}

		/// <summary>
		/// Write a program in C# Sharp to display the n terms of odd natural number and their sum.
		/// </summary>
		public static void Exercicio8()
		{
			int number, value = 0;

			Console.WriteLine("Insert a number: ");
			number = Convert.ToInt32(Console.ReadLine());

			for (int i = 1; i <= number; i++)
			{
				Console.WriteLine("{0}", 2 * i - 1);
				value += 2 * i - 1;
			}

			Console.WriteLine("The sum of odd natural number upto {0} terms: {1} \n", number, value);
		}

		/// <summary>
		/// Write a program in C# Sharp to display the multiplication table vertically from 1 to n.
		/// </summary>
		public static void Exercicio7()
		{
			int number;

			Console.WriteLine("Input a number: ");
			number = Convert.ToInt32(Console.ReadLine());

			for (int i = 1; i <= number; i++)
			{
				var value = i * 1;

				Console.WriteLine("{0} x 1 = {1}", i, value);
			}
		}

		/// <summary>
		/// Write a program in C# Sharp to display the multiplication table of a given integer.
		/// </summary>
		public static void Exercicio6()
		{
			int number;

			Console.WriteLine("Input a number: ");
			number = Convert.ToInt32(Console.ReadLine());

			for (int i = 1; i <= 10; i++)
			{
				var multiply = number * i;

				Console.WriteLine("{0} x {1} = {2}", number, i, multiply);
			}
		}

		/// <summary>
		/// Write a program in C# Sharp to display the cube of the number upto given an integer.
		/// </summary>
		public static void Exercicio5()
		{
			int number;
			
			Console.WriteLine("Insert a number: ");
			number = Convert.ToInt32(Console.ReadLine());

			for (int i = 1; i <= number; i++)
			{
				int cube = i * i * i;
				Console.WriteLine("Number is: {0} and the cube is: {1}", i, cube);
			}
		}

		/// <summary>
		/// Write a program in C# Sharp to read 10 numbers from keyboard and find their sum and average.
		/// </summary>
		public static void Exercicio4()
		{
			int i, n, sum = 0;
			double avg;

			for (i = 1; i <= 10; i++)
			{
				Console.WriteLine("Number-{0} :", i);

				n = Convert.ToInt32(Console.ReadLine());
				sum += n;
			}

			avg = sum / 10.0;
			Console.WriteLine("The sum : {0}\nThe Avarege is : {1}", sum, avg);
		}

		/// <summary>
		/// Write a program in C# Sharp to display n terms of natural number and their sum.
		/// </summary>
		public static void Exercicio3()
		{
			int n;
			var sum = 0;

			Console.WriteLine("Test Data: ");
			n = Convert.ToInt32(Console.ReadLine());

			for (int i = 1; i <= n; i++)
			{
				Console.WriteLine("{0}", i);

				sum = sum + i;
			}

			Console.WriteLine("Sum of all numbers: {0}", sum);
		}

		/// <summary>
		/// Write a C# Sharp program to find the sum of first 10 natural numbers.
		/// </summary>
		public static void Exercicio2()
		{
			var sum = 0;
			for (int i = 1; i <= 10; i++)
			{
				sum = sum + i;
			}

			Console.WriteLine("Sum of all numbers: {0}", sum);
		}

		/// <summary>
		/// Write a program in C# Sharp to display the first 10 natural numbers.
		/// </summary>
		public static void Exercicio1()
		{
			int i;
			for (i = 1; i <= 10; i++)
			{
				Console.WriteLine("{0}", i);
			}
		}
	}
}
