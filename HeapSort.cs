using System;

public class HeapSort {
	public static void sort(int[] a)
	{
		int N = a.Length;

		for (int i = N / 2 - 1; i >= 0; i--)
			heapify(a, N, i);

		for (int i = N - 1; i > 0; i--) {
			int temp = a[0];
			a[0] = a[i];
			a[i] = temp;

			heapify(a, i, 0);
		}
	}

 	static void heapify(int[] a, int N, int i)
	{
		int largest = i; 
		int l = 2 * i + 1; 
		int r = 2 * i + 2; 

		if (l < N && a[l] > a[largest])
			largest = l;

		if (r < N && a[r] > a[largest])
			largest = r;

		if (largest != i) {
			int swap = a[i];
			a[i] = a[largest];
			a[largest] = swap;

			heapify(a, N, largest);
		}
	}

	static void printarray(int[] a)
	{
		int N = a.Length;
		for (int i = 0; i < N; ++i)
			Console.Write(a[i] + " ");
		Console.WriteLine();
		Console.Read();
	}

	public static void Main()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		int[] a = new int[n];
		int N = a.Length;
		for(int i=0;i<N;i++)
		{
			a[i] = Convert.ToInt32(Console.ReadLine());
		}

		sort(a);

		Console.Write("The sorted array is: ");
		printarray(a);
	}
}


