using System;
class MergeSort {

	void merge(int[] a, int left, int middle, int right)
	{
		int n1 = middle - left + 1;
		int n2 = right - middle;

		int[] L = new int[n1];
		int[] R = new int[n2];
		int i, j;

		for (i = 0; i < n1; ++i)
			L[i] = a[left + i];
		for (j = 0; j < n2; ++j)
			R[j] = a[middle + 1 + j];


		i = 0;
		j = 0;

		int k = left;
		while (i < n1 && j < n2) {
			if (L[i] <= R[j]) {
				a[k] = L[i];
				i++;
			}
			else {
				a[k] = R[j];
				j++;
			}
			k++;
		}

		while (i < n1) {
			a[k] = L[i];
			i++;
			k++;
		}

		while (j < n2) {
			a[k] = R[j];
			j++;
			k++;
		}
	}

	void sort(int[] a, int left, int right)
	{
		if (left < right) {
			int middle = left + (right - left) / 2;

			sort(a, left, middle);
			sort(a, middle + 1, right);

			merge(a, left, middle, right);
		}
	}


	static void printArray(int[] a)
	{
		int n = a.Length;
		for (int i = 0; i < n; ++i)
			Console.Write(a[i] + " ");
		Console.WriteLine();
	}

	public static void Main(String[] args)
	{
		int n = Convert.ToInt32(Console.ReadLine());
		int[] a = new int[n];
		for(int i=0;i<a.Length;i++)
		{
			a[i] = Convert.ToInt32(Console.ReadLine());
		}
		Console.Write("Given Array: ");
		printArray(a);
		Console.WriteLine();
		MergeSort ob = new MergeSort();
		ob.sort(a, 0, a.Length - 1);
		Console.Write("Sorted Array: ");
		printArray(a);
		Console.WriteLine();
	}
}


