using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpExercicesW3Resources
{
	public class Array
	{
		/// <summary>
		/// Write a program in C# Sharp to count a total number of duplicate elements in an array.
		/// </summary>
		//public static void Exercicio5()
		//{
		//	int n;
		//	int[] array = new int[10];

		//	Console.WriteLine("Input the number of elements to store in the array: ");
		//	n = Convert.ToInt32(Console.ReadLine());

		//	for (int i = 0; i < n; i++)
		//	{
		//		Console.Write("element - {0}: ", i);
		//		array[i] = Convert.ToInt32(Console.ReadLine());
		//	}

		//	for (int i = 0; i < array.Length; i++)
		//	{
		//		int count = 0;
		//		for (int j = 0; j < array.Length; j++)
		//		{
		//			if (array[i] == array[j])
		//			{
		//				count = count + 1;
		//			}
		//		}
		//		Console.WriteLine("Total number of duplicate elements found in the array is: {0}", count);
		//	}


		//}

		/// <summary>
		/// Write a program in C# Sharp to copy the elements one array into another array.
		/// </summary>
		public static void Exercicio4()
		{
			int n;
			int[] array1 = new int[10];
			int[] array2 = new int[10];

			Console.WriteLine("Input the number of elements to store in the array: ");
			n = Convert.ToInt32(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				Console.Write("element - {0}: ", i);
				array1[i] = Convert.ToInt32(Console.ReadLine());
			}

			for (int i = 0; i < n; i++)
			{
				array2[i] = array1[i];
			}

			Console.Write("\nThe elements in the first array are :\n");
			for (int i = 0; i < n; i++)
			{
				Console.Write("{0} ", array1[i]);
			}

			Console.Write("\n\nThe elements copied into the second array are :\n");
			for (int i = 0; i < n; i++)
			{
				Console.Write("{0} ", array2[i]);
			}

		}

		/// <summary>
		/// Write a program in C# Sharp to find the sum of all elements of the array.
		/// </summary>
		public static void Exercicio3()
		{
			int n, sum = 0;
			int[] array = new int[10];

			Console.WriteLine("Input the number of elements to store in the array: ");
			n = Convert.ToInt32(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				Console.Write("element - {0}: ", i);
				array[i] = Convert.ToInt32(Console.ReadLine());
			}

			for (int i = 0; i < n; i++)
			{
				sum += array[i];
			}

			Console.Write("Sum of all elements is equal to: {0}", sum);
		}

		/// <summary>
		/// Write a program in C# Sharp to read n number of values in an array and display it in reverse order.
		/// </summary>
		public static void Exercicio2()
		{
			int number;
			int[] array = new int[100];

			Console.WriteLine("Input the number of elements to store in the array: ");
			number = Convert.ToInt32(Console.ReadLine());

			for (int i = 0; i < number; i++)
			{
				Console.Write("element - {0} : ", i);
				array[i] = Convert.ToInt32(Console.ReadLine());
			}

			Console.Write("The values stored into the array are: \n");
			for (int i = 0; i < number; i++)
			{
				Console.Write("{0} ", array[i]);
			}

			Console.Write("\nThe values stored into the array in reverse are: \n");
			for (int i = number - 1; i >= 0; i--)
			{
				Console.Write("{0} ", array[i]);
			}
		}

		/// <summary>
		/// Write a program in C# Sharp to store elements in an array and print it
		/// </summary>
		public static void Exercicio1()
		{
			int[] array = new int[10];

			for (int i = 0; i < 10; i++)
			{
				Console.Write("element - {0} : ", i);
				array[i] = Convert.ToInt32(Console.ReadLine());
			}

			for (int i = 0; i < 10; i++)
			{
				Console.Write("{0}", array[i]);
			}
		}
	}
}
