using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpExercicesW3Resources
{
	public class ArrayExercises
	{

		/// <summary>
		/// Write a program in C# Sharp to find the second smallest element in an array.
		/// </summary>
		public static void Exercicio17()
		{
			int[] array = { 0,9,4,6,5 };
			int first, second;

			first = second = int.MaxValue;

			for (int i = 0; i < array.Length; i++)
			{
				///If current element is smaller than first then update both first and second
				if (array[i] < first)
				{
					second = first;
					first = array[i];
				}
				else if (array[i] < second && array[i] != first)
				{
					second = array[i];
				}
			}

			if (second != int.MaxValue)
			{
				Console.Write("The second smallest element is: ", second);
			}
		}

		/// <summary>
		/// Write a program in C# Sharp to find the second largest element in an array.
		/// </summary>
		public static void Exercicio16()
		{
			int[] array = { 2, 9, 1, 4, 6 };

			Array.Sort(array);

			for (int i = array.Length - 2; i >= 0; i--)
			{
				if (array[i] != array[array.Length - 1])
				{
					Console.WriteLine("The second largest element is {0}\n", array[i]);
					return;
				}
			}
		}

		/// <summary>
		/// Write a program in C# Sharp to delete an element at desired position from an array.
		/// </summary>
		public static void Exercicio15()
		{
			int[] array = { 1, 2, 3, 4, 5 };
			int position;

			Console.WriteLine("Insert the position that you want to delete: ");
			position = Convert.ToInt32(Console.ReadLine());

			List<int> list = new List<int>(array);
			list.RemoveAt(array[position - 1]);
			array = list.ToArray();

			foreach (var item in array)
			{
				Console.WriteLine("{0} ", item);
			}
		}

		/// <summary>
		/// Write a program in C# Sharp to insert New value in the array (unsorted list ).
		/// </summary>
		public static void Exercicio14()
		{
			int[] arr1 = new int[10];
			int i, n, p, x;

			Console.Write("\n\nInsert New value in the unsorted array : \n");
			Console.Write("-----------------------------------------\n");
			Console.Write("Input the size of array : ");
			n = Convert.ToInt32(Console.ReadLine());
			/* Stored values into the array*/
			Console.Write("Input {0} elements in the array in ascending order:\n", n);
			for (i = 0; i < n; i++)
			{
				Console.Write("element - {0} : ", i);
				arr1[i] = Convert.ToInt32(Console.ReadLine());
			}


			Console.Write("Input the value to be inserted : ");
			x = Convert.ToInt32(Console.ReadLine());
			Console.Write("Input the Position, where the value to be inserted :");
			p = Convert.ToInt32(Console.ReadLine());

			Console.Write("The current list of the array :\n");
			for (i = 0; i < n; i++)
				Console.Write("{0} ", arr1[i]);
			/* Move all data at right side of the array */
			for (i = n; i >= p; i--)
				arr1[i] = arr1[i - 1];
			/* insert value at given position */
			arr1[p - 1] = x;


			Console.Write("\n\nAfter Insert the element the new list is :\n");
			for (i = 0; i <= n; i++)
				Console.Write("{0} ", arr1[i]);
			Console.Write("\n\n");
		}

		/// <summary>
		/// Write a program in C# Sharp to insert New value in the array (sorted list ).
		/// </summary>
		public static void Exercicio13()
		{
			int[] array = { 5, 7, 9 };
			int[] array2 = new int[array.Length + 1];

			int number;

			Console.WriteLine("Insert the number to add to the array: ");
			number = Convert.ToInt32(Console.ReadLine());

			for (int i = 0; i < array.Length; i++)
			{
				array2[i] = array[i];
			}

			array2[array2.Length - 1] = number;

			foreach (var item in array2)
			{
				Console.Write(item);
			}
		}

		/// <summary>
		/// Write a program in C# Sharp to sort elements of the array in descending order.
		/// </summary>
		public static void Exercicio12()
		{
			int[] array = { 5, 9, 1 };

			array = array.OrderByDescending(a => a).ToArray();

			foreach (var item in array)
			{
				Console.Write(item);
			}
		}

		/// <summary>
		/// Write a program in C# Sharp to sort elements of array in ascending order.
		/// </summary>
		public static void Exercicio11()
		{
			int[] array = { 2, 7, 4, 5, 9 };

			///Sort the array in ascending order
			///and return the array
			array = array.OrderBy(a => a).ToArray();

			foreach (var item in array)
			{
				Console.Write(item);
			}
		}

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
