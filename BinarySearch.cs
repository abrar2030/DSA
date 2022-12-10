using System;

class BinarySearch {

	public static void Main(String[] args)
	{

		int n = Convert.ToInt32(Console.ReadLine());

		int[] a = new int[n];
		for(int i=0;i<a.Length;i++)
		{
			a[i] = Convert.ToInt32(Console.ReadLine());
		}

		Array.Sort(a);

		Console.Write("The elements of Sorted Array: ");

		display(a);
		Console.WriteLine();
		Console.Write("Enter the target number: ");

		object s = Convert.ToInt32(Console.ReadLine());

		result(a, s);

	}

	static void result(int[] a2, object k)
	{

		int res = Array.BinarySearch(a2, k);

		if (res < 0) {
			Console.WriteLine("\nThe element to search for " + "({0}) is not found.", k);
		}

		else {
			Console.WriteLine("The element to search for " + "({0}) is at index {1}.", k, res);
		}
	}

	static void display(int[] a)
	{

		foreach(int i in a)
			Console.Write(i + " ");
	}
}

