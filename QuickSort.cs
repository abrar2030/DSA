using System;

class QuickSort {

	static void swap(int[] a, int i, int j)
	{
		int temp = a[i];
		a[i] = a[j];
		a[j] = temp;
	}

	static int partition(int[] a, int low, int high)
	{

		int pivot = a[high];

		int i = (low - 1);

		for (int j = low; j <= high - 1; j++) {

			if (a[j] < pivot) {

				i++;
				swap(a, i, j);
			}
		}
		swap(a, i + 1, high);
		return (i + 1);
	}

	static void sort(int[] a, int low, int high)
	{
		if (low < high) {

			int pi = partition(a, low, high);

			sort(a, low, pi - 1);
			sort(a, pi + 1, high);
		}
	}

	static void printarray(int[] a, int size)
	{
		for (int i = 0; i < size; i++)
			Console.Write(a[i] + " ");

		Console.WriteLine();
	}

	public static void Main()
	{
		int k= Convert.ToInt32(Console.ReadLine());
		int[] a = new int[k];
		int n = a.Length;
		for(int i=0;i<n;i++)
		{
			a[i] = Convert.ToInt32(Console.ReadLine());
		}

		sort(a, 0, n - 1);
		Console.Write("The sorted array is: ");
		printarray(a, n);
	}
}


