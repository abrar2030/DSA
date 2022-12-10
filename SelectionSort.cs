using System;

class SelectionSort 
{
	static void sort(int []a)
	{
		int n = a.Length;

		for (int i = 0; i < n - 1; i++)
		{
			int p = i;
			for (int j = i + 1; j < n; j++)
				if (a[j] < a[p])
					p = j;

			int temp = a[p];
			a[p] = a[i];
			a[i] = temp;
		}
	}

	static void printarray(int []a)
	{
		int n = a.Length;
		for (int i=0; i<n; ++i)
			Console.Write(a[i]+" ");
		Console.WriteLine();
	}

	public static void Main()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		int []a = new int[n];
		for(int i=0;i<a.Length;i++)
		{
			a[i] = Convert.ToInt32(Console.ReadLine());
		}
		sort(a);
		Console.Write("The sorted array is: ");
		printarray(a);
	}

}

