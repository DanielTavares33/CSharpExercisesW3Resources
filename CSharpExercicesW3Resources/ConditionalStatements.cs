using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpExercicesW3Resources
{
	class ConditionalStatements
	{
		/// <summary>
		/// Write a C# Sharp program to accept the height of a person in centimeter and categorize the person according to their height.
		/// </summary>
		public static void Exercicio7()
		{
			float height;

			Console.WriteLine("Insert a height: ");
			height = Convert.ToInt32(Console.ReadLine());

			if (height < 150.0)
			{
				Console.WriteLine("You are short!");
			}else if(height >= 150.0 && height <= 165.0)
			{
				Console.WriteLine("You are in the avarage height!");
			}
			else
			{
				Console.WriteLine("You are tall!");
			}


		}

		/// <summary>
		/// Write a C# Sharp program to read the value of an integer m and display the value of n is 1 when m 
		/// is larger than 0, 0 when m is 0 and -1 when m is less than 0. 
		/// </summary>
		public static void Exercicio6()
		{
			int m, n;

			Console.WriteLine("Insert a number: ");
			m = Convert.ToInt32(Console.ReadLine());

			if (m != 0)
			{
				if (m > 0)
				{
					n = 1;
				}
				else
				{
					n = -1;
				}
			}
			else
			{
				n = 0;
			}

			Console.WriteLine("The value of m = {0}", m);
			Console.WriteLine("The value of n = {0]", n);
		}

		/// <summary>
		/// Write a C# Sharp program to read the age of a candidate and determine whether it is eligible for casting his/her own vote.
		/// </summary>
		public static void Exercicio5()
		{
			int age;

			Console.WriteLine("Insert your age: ");
			age = Convert.ToInt32(Console.ReadLine());

			if (age >= 18)
			{
				Console.WriteLine("Congratulations! You are eligible for casting your vote.");
			}
			else
			{
				Console.WriteLine("You don't have age to vote");
			}
		}

		/// <summary>
		/// Write a C# Sharp program to find whether a given year is a leap year or not.
		/// </summary>
		public static void Exercicio4()
		{
			int year;

			Console.WriteLine("Insert a year: ");
			year = Convert.ToInt32(Console.ReadLine());

			if (year % 400 == 0)
			{
				Console.WriteLine("{0} is a leap year", year);
			}
			else if (year % 100 == 0)
			{
				Console.WriteLine("{0} is not a leap year", year);
			}
			else if (year % 4 == 0)
			{
				Console.WriteLine("{0} is a leap year", year);
			}
			else
			{
				Console.WriteLine("{0} is not a leap year", year);
			}

		}

		/// <summary>
		/// Write a C# Sharp program to check whether a given number is positive or negative.
		/// </summary>
		public static void Exercicio3()
		{
			int n1;

			Console.WriteLine("Insert a number: ");
			n1 = Convert.ToInt32(Console.ReadLine());

			if (n1 >= 0)
			{
				Console.WriteLine("{0} is a positive number", n1);
			}
			else
			{
				Console.WriteLine("{0} is a negative number", n1);
			}
		}

		/// <summary>
		/// Write a C# Sharp program to check whether a given number is even or odd.
		/// </summary>
		public static void Exercicio2()
		{
			int n1;

			Console.WriteLine("Insert a number: ");
			n1 = Convert.ToInt32(Console.ReadLine());

			if (n1 % 2 == 0)
			{
				Console.WriteLine("{0} is and even intenger", n1);
			}else
			{
				Console.WriteLine("{0} is and odd intenger", n1);
			}
		}

		/// <summary>
		/// Write a C# Sharp program to accept two integers and check whether they are equal or not. 
		/// </summary>
		public static void Exercicio1()
		{
			int n1, n2;

			Console.WriteLine("Insert first number: ");
			n1 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Insert second number: ");
			n2 = Convert.ToInt32(Console.ReadLine());

			if (n1 != n2)
			{
				Console.WriteLine("{0} and {1} are not equal", n1, n2);
			}
			else
			{
				Console.WriteLine("{0} and {1} are equal", n1, n2);
			}
		}
	}
}
