using System;

class InsertionSort {

	void sort(int[] a)
	{
		int n = a.Length;
		for (int i = 1; i < n; ++i) {
			int k = a[i];
			int j = i - 1;

			while (j >= 0 && a[j] > k) {
				a[j + 1] = a[j];
				j = j - 1;
			}
			a[j + 1] = k;
		}
	}

	static void printarray(int[] a)
	{
		int n = a.Length;
		for (int i = 0; i < n; ++i)
			Console.Write(a[i] + " ");

		Console.WriteLine();
	}

	public static void Main()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		int[] a = new int[n];
		for(int i=0;i<a.Length;i++)
		{
			a[i] = Convert.ToInt32(Console.ReadLine());
		}
		InsertionSort s = new InsertionSort();
		s.sort(a);
		printarray(a);
	}
}


