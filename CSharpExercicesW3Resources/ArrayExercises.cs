using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpExercicesW3Resources
{
	public class ArrayExercises
	{
		/// <summary>
		/// Write a programin C# Sharp to separate odd and even integers in separate arrays.
		/// </summary>
		public static void Exercicio10()
		{
			int[] array = { 25, 47, 42, 56, 32 };

			int[] oddArray = new int[5];
			int[] evenArray = new int[5];

			int j = 0, k = 0;

			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] % 2 == 0)
				{
					evenArray[j] = array[i];
					j++;
				}
				else
				{
					oddArray[k] = array[i];
					k++;
				}
			}

			for (int i = 0; i < j; i++)
			{
				Console.WriteLine("Odd number: {0}", oddArray[i]);
			}

			for (int i = 0; i < k; i++)
			{
				Console.WriteLine("Even number: {0}", evenArray[i]);
			}
		}

		/// <summary>
		/// Write a program in C# Sharp to find maximum and minimum element in an array.
		/// </summary>
		public static void Exercicio9()
		{
			int[] array = { 45, 25, 21 };
			int max, min;

			max = array[0];
			min = array[0];

			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] > max)
				{
					max = array[i];
				}

				if (array[i] < min)
				{
					min = array[i];
				}
			}

			Console.WriteLine("Maximum element is: {0}", max);
			Console.WriteLine("Minimum element is: {0}", min);
		}

		/// <summary>
		/// Write a program in C# Sharp to count the frequency of each element of an array.
		/// </summary>
		public static void Exercicio8()
		{
			int[] arr1 = new int[100];
			int[] fr1 = new int[100];
			int n, i, j, ctr;

			Console.Write("Input the number of elements to be stored in the array :");
			n = Convert.ToInt32(Console.ReadLine());

			Console.Write("Input {0} elements in the array :\n", n);
			for (i = 0; i < n; i++)
			{
				Console.Write("element - {0} : ", i);
				arr1[i] = Convert.ToInt32(Console.ReadLine());
				fr1[i] = -1;
			}

			for (i = 0; i < n; i++)
			{
				ctr = 1;
				for (j = i + 1; j < n; j++)
				{
					if (arr1[i] == arr1[j])
					{
						ctr++;
						fr1[j] = 0;
					}
				}

				if (fr1[i] != 0)
				{
					fr1[i] = ctr;
				}
			}

			Console.Write("\nThe frequency of all elements of the array : \n");
			for (i = 0; i < n; i++)
			{
				if (fr1[i] != 0)
				{
					Console.Write("{0} occurs {1} times\n", arr1[i], fr1[i]);
				}
			}
		}

		/// <summary>
		/// Write a program in C# Sharp to merge two arrays of same size sorted in ascending order.
		/// </summary>
		public static void Exercicio7()
		{
			int[] arrayOne = { 1, 2, 3 };

			int[] arrayTwo = { 1, 2, 3 };

			int[] arrayThree = new int[6];

			arrayOne.CopyTo(arrayThree, 0);

			arrayTwo.CopyTo(arrayThree, 3);

			Array.Sort(arrayThree);

			foreach (var item in arrayThree)
			{
				Console.WriteLine(item);
			}
		}

		/// <summary>
		/// Write a program in C# Sharp to print all unique elements in an array. 
		/// </summary>
		public static void Exercicio6()
		{
			int n, counter = 0;
			int[] array = new int[10];

			Console.WriteLine("Insert the max number of the array: ");
			n = Convert.ToInt32(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				Console.Write("element - {0}: ", i);
				array[i] = Convert.ToInt32(Console.ReadLine());
			}

			for (int i = 0; i < n; i++)
			{
				foreach (var val in array)
				{
					if (array[i] == val)
					{
						counter++;
					}
				}

				if (counter < 2)
				{
					Console.Write("{0}", array[i]);
				}

				counter = 0;
			}
		}

		/// <summary>
		/// Write a program in C# Sharp to count a total number of duplicate elements in an array.
		/// </summary>
		public static void Exercicio5()
		{
			int[] arr1 = new int[100];
			int[] arr2 = new int[100];
			int[] arr3 = new int[100];
			int s1, s2, mm = 1, ctr = 0;
			int i, j;
			Console.Write("\n\nCount total number of duplicate elements in an array:\n");
			Console.Write("---------------------------------------------------------\n");

			Console.Write("Input the number of elements to be stored in the array :");
			s1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Input {0} elements in the array :\n", s1);
			for (i = 0; i < s1; i++)
			{
				Console.Write("element - {0} : ", i);
				arr1[i] = Convert.ToInt32(Console.ReadLine());
			}
			/*----------------- copy in other array ------------------------------------*/
			for (i = 0; i < s1; i++)
			{
				arr2[i] = arr1[i];
				arr3[i] = 0;
			}
			/*------------------- mark the elements are duplicate -------------------------*/
			for (i = 0; i < s1; i++)
			{
				for (j = 0; j < s1; j++)
				{
					if (arr1[i] == arr2[j])
					{
						arr3[j] = mm;
						mm++;
					}
				}
				mm = 1;
			}
			/*--------------- Prints the array ------------------------------------*/
			for (i = 0; i < s1; i++)
			{
				if (arr3[i] == 2) { ctr++; }
			}
			Console.Write("The number of duplicate elements is: {0} \n", ctr);

			Console.Write("\n\n");
		}


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
