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
		/// Write a program in C# Sharp to find the sum of the series [ 1-X^2/2!+X^4/4!- .........].
		/// </summary>
		public static void Exercicio18()
		{
			double x, sum, t, d;
			int i, n;

			Console.Write("\n\n");
			Console.Write("Calculate the sum of the series [ 1-X^2/2!+X^4/4!- .........]:\n");
			Console.Write("----------------------------------------------------------------");
			Console.Write("\n\n");

			Console.Write("Input the Value of x :");
			x = Convert.ToInt32(Console.ReadLine());

			Console.Write("Input the number of terms : ");
			n = Convert.ToInt32(Console.ReadLine());

			sum = 1; t = 1;
			for (i = 1; i < n; i++)
			{
				d = (2 * i) * (2 * i - 1);
				t = -t * x * x / d;
				sum = sum + t;
			}
			Console.Write("\nthe sum = {0}\nNumber of terms = {1}\nvalue of x = {2}\n", sum, n, x);
		}

		/// <summary>
		/// Write a program in C# Sharp to make such a pattern like a pyramid witha number which will repeat the number in the same row
		/// </summary>
		public static void Exercicio17()
		{
			int space;
			int rows = 4;

			space = rows + 4 - 1;
			for (int i = 1; i <= rows; i++)
			{
				for (int k = space; k >= 1; k--)
				{
					Console.Write(" ");
				}

				for (int j = 1; j <= i; j++)
				{
					Console.Write("{0} ", i);
				}
				Console.Write("\n");
				space--;
			}
		}

		/// <summary>
		/// Write a program in C# Sharp to display the n terms of even natural number and their sum.
		/// </summary>
		public static void Exercicio16()
		{
			int n;
			int sum = 0;

			Console.Write("Insert the number: ");
			n = Convert.ToInt32(Console.ReadLine());

			Console.Write("\nThe even numbers are: ");
			for (int i = 1; i <= n; i++)
			{
				Console.Write("{0} ", 2 * i);
				sum += 2 * i;
			}

			Console.Write("\nThe Sum of even Natural Number upto {0} terms: {1} \n", n, sum);
		}

		/// <summary>
		/// Write a C# Sharp program to calculate the factorial of a given number.
		/// </summary>
		public static void Exercicio15()
		{
			int n;
			var factorial = 1;

			Console.Write("Insert the number: ");
			n = Convert.ToInt32(Console.ReadLine());

			for (int i = 1; i <= n; i++)
			{
				factorial *= i;
			}

			Console.Write("The factorial of {0} is: {1}", n, factorial);
		}

		/// <summary>
		/// Write a program in C# Sharp to make such a pattern like a pyramid with an asterisk.
		/// </summary>
		public static void Exercicio14()
		{
			int space;
			int rows = 4;

			space = rows + 4 - 1;
			for (int i = 1; i <= rows; i++)
			{
				for (int k = space; k >= 1; k--)
				{
					Console.Write(" ");
				}

				for (int j = 1; j <= i; j++)
				{
					Console.Write("* ");
				}
				Console.Write("\n");
				space--;
			}
		}

		/// <summary>
		/// Write a program in C# Sharp to make such a pattern like a pyramid with numbers increased by 1.
		/// </summary>
		public static void Exercicio13()
		{
			int space, t = 1;
			int rows = 4;

			space = rows + 4 - 1;
			for (int i = 1; i <= rows; i++)
			{
				for (int k = space; k >= 1; k--)
				{
					Console.Write(" ");
				}

				for (int j = 1; j <= i; j++)
				{
					Console.Write("{0} ", t++);
				}
				Console.Write("\n");
				space--;
			}
		}

		/// <summary>
		///  Write a program in C# Sharp to make such a pattern like right angle triangle with number increased by 1.
		/// </summary>
		public static void Exercicio12()
		{
			int rows = 4;
			int inc = 1;

			for (int i = 1; i <= rows; i++)
			{
				for (int j = 1; j <= i; j++)
				{
					Console.Write("{0} ", inc++);
				}
				Console.Write("\n");
			}
		}

		/// <summary>
		/// Write a program in C# Sharp to make such a pattern like right angle triangle with a number which will repeat a number in a row.
		/// </summary>
		public static void Exercicio11()
		{
			for (int i = 1; i <= 4; i++)
			{
				for (int j = 1; j <= i; j++)
				{
					Console.Write("{0}", i);
				}
				Console.Write("\n");
			}

		}

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
