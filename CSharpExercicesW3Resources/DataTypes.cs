using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpExercicesW3Resources
{
	public class DataTypes
	{
		public static void Main(string[] args)
		{
			Exercicio10();
			//Console.ReadLine();
		}

		/// <summary>
		/// Write a C# Sharp program that takes a decimal number as input and displays its equivalent in binary form.
		/// </summary>
		public static void Exercicio10()
		{
			string answer, result;

			Console.Write("Number to convert to binary: ");
			answer = Console.ReadLine();

			int num = Convert.ToInt32(answer);
			result = "";

			while (num > 1)
			{
				int remainder = num % 2;
				result = Convert.ToString(remainder) + result;
				num /= 2;
			}

			result = Convert.ToString(num) + result;
			Console.WriteLine("Binary: {0}", result);


		}

		/// <summary>
		/// Write a C# Sharp program that takes two numbers as input and returns true or false when both numbers are even or odd.
		/// </summary>
		public static void Exercicio9()
		{
			int number1, number2;
			bool bothEven;

			Console.Write("Input first number: ");
			number1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Input second number: ");
			number2 = Convert.ToInt32(Console.ReadLine());

			bothEven = ((number1 % 2 == 0) && (number2 % 2 == 0)) ? true : false;

			Console.WriteLine(bothEven ? "they are both even" : "there's a number odd");
		}


		/// <summary>
		/// Write a C# Sharp program that takes a character as input and check the input (lowercase) is a vowel, 
		/// a digit, or any other symbol.
		/// </summary>
		public static void Exercicio8()
		{
			char symbol;

			Console.Write("Input a symbol: ");
			symbol = Convert.ToChar(Console.ReadLine());

			if ((symbol == 'a') || (symbol == 'e') || (symbol == 'i') || (symbol == 'o') || (symbol == 'u'))
			{
				Console.WriteLine("It's is a lowercase vowel.");
			}
			else if (symbol >= '0' && symbol <= '9')
			{
				Console.WriteLine("It's a digit.");
			}
			else
			{
				Console.WriteLine("It's another symbol");
			}
		}

		/// <summary>
		/// Write a C# Sharp program that takes the radius of a sphere as input and calculate and display the surface 
		/// and volume of the sphere.
		/// </summary>
		public static void Exercicio7()
		{
			float radius;
			double pi = Math.PI;

			Console.Write("Radius: ");
			radius = Convert.ToSingle(Console.ReadLine());

			Console.WriteLine(4 * pi * (radius * radius));
			Console.WriteLine(4f / 3f * pi * (radius * radius * radius));
		}

		/// <summary>
		/// Write a C# Sharp program that takes distance and time as input and displays 
		/// the speed in kilometers per hour and miles per hour.
		/// </summary>
		public static void Exercicio6()
		{
			float distance;
			float hour, min, sec;

			float timeSec;
			float mps;
			float kph, mph;

			Console.WriteLine("Input distance(meters): ");
			distance = Convert.ToSingle(Console.ReadLine());

			Console.WriteLine("Input timeSec(hour): ");
			hour = Convert.ToSingle(Console.ReadLine());

			Console.WriteLine("Input timeSec(minutes): ");
			min = Convert.ToSingle(Console.ReadLine());

			Console.WriteLine("Input timeSec(seconds): ");
			sec = Convert.ToSingle(Console.ReadLine());

			timeSec = (hour * 3000) + (min * 60) + sec;
			mps = distance / timeSec;
			kph = (distance / 1000.0f) / (timeSec / 3600.0f);
			mph = kph / 1.609f;

			Console.WriteLine("Your speed in meters/sec is {0}", mps);
			Console.WriteLine("Your speed in km/h is {0}", kph);
			Console.WriteLine("Your speed in miles/h is {0}", mph);
		}

		/// <summary>
		/// Write a C# Sharp program to display certain values of the function x = y2 + 2y + 1 
		/// (using integer numbers for y , ranging from -5 to +5)
		/// </summary>
		public static void Exercicio5()
		{
			int x, y;

			Console.WriteLine("x = y^2 - 2y + 1");
			for (y = -5; y <= 5; y++)
			{
				x = y * y - 2 * y + 1;
				Console.WriteLine("y = {0} ; x = ({0})^2 - 2({0}) + 1 = {1}", y, x);
			}
		}

		/// <summary>
		/// Write a C# Sharp program that takes the radius of a circle as input and calculate the perimeter and area of the circle.
		/// </summary>
		public static void Exercicio4()
		{
			double radius, perimeter;

			Console.Write("Input the radius of the circle: ");
			radius = Convert.ToDouble(Console.ReadLine());

			perimeter = 2 * Math.PI * radius;

			Console.WriteLine("Perimeter of Circle: {0}", Convert.ToDecimal(string.Format("{0:0.00}", perimeter)));
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
