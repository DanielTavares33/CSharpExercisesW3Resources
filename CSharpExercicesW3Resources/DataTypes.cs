using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpExercicesW3Resources
{
	public class DataTypes
	{
		public static void Main(string[] args)
		{
			Exercicio4();
			//Console.ReadLine();
		}


		public static void Exercicio4()
		{
			int radius;

			Console.Write("Input the radius of the circle: ");
			radius = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Perimeter of Circle: {0}", Math.Round(2 * Math.PI * radius));
			Console.WriteLine("Area of Circle: {0}", Math.Round(Math.PI * Math.Log(radius)));
		}

		/// <summary>
		/// Write a C# Sharp program that takes two numbers as input and perform an operation (+,-,*,x,/) 
		/// on them and displays the result of that operation.
		/// </summary>
		public static void Exercicio3()
		{
			int number1, number2;
			char operation;

			Console.Write("Enter first number: ");
			number1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter operation: ");
			operation = Convert.ToChar(Console.ReadLine());

			Console.Write("Enter second number: ");
			number2 = Convert.ToInt32(Console.ReadLine());

			/// Solucao 2

			if (operation == '+')
				Console.WriteLine("{0} + {1} = {2}", number1, number2, number1 + number2);
			else if (operation == '-')
				Console.WriteLine("{0} - {1} = {2}", number1, number2, number1 - number2);
			else if (operation == 'x' || operation == '*')
				Console.WriteLine("{0} * {1} = {2}", number1, number2, number1 * number2);
			else if (operation == '/')
				Console.WriteLine("{0} / {1} = {2}", number1, number2, number1 / number2);
			else
				Console.WriteLine("Wrong operation");

			///Solução 1
			//if (operation == "+")
			//{
			//	result = number1 + number2;
			//}
			//else if (operation == "-")
			//{
			//	result = number1 - number2;
			//}
			//else if (operation == "*")
			//{
			//	result = number1 * number2;
			//}
			//else if (operation == "x")
			//{
			//	result = number1 * number2;
			//}
			//else if (operation == "/")
			//{
			//	result = number1 / number2;
			//}
			//else
			//{
			//	Console.WriteLine("Insert operation");
			//}
			//Console.WriteLine(result);
		}

		/// <summary>
		/// Write a C# Sharp program that takes a number and a width also a number, 
		/// as input and then displays a triangle of that width, using that number.
		/// </summary>
		public static void Exercicio2()
		{
			int number, width;

			Console.WriteLine("Enter a number: ");
			number = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter the desire with: ");
			width = Convert.ToInt32(Console.ReadLine());


			int height = width;
			for (int row = 0; row < height; row++)
			{
				for (int column = 0; column < width; column++)
				{
					Console.Write(number);
				}

				Console.WriteLine();
				width--;
			}
		}

		/// <summary>
		/// Write a C# Sharp program that takes three letters as input and display them in reverse order.
		/// </summary>
		public static void Exercicio1()
		{
			char letter, letter1, letter2;

			Console.Write("Input a letter: ");
			letter = Convert.ToChar(Console.ReadLine());

			Console.Write("Input a letter: ");
			letter1 = Convert.ToChar(Console.ReadLine());

			Console.Write("Input a letter: ");
			letter2 = Convert.ToChar(Console.ReadLine());

			Console.WriteLine("{0} {1} {2}", letter2, letter1, letter);
		}
	}
}
