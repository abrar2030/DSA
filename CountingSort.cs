using System;
using System.Collections.Generic;
using System.Linq;

class CountingSort {

	static void sort(int[] a)
	{
		int max = a.Max();
		int min = a.Min();
		int range = max - min + 1;
		int[] count = new int[range];
		int[] output = new int[a.Length];
		for (int i = 0; i < a.Length; i++) {
			count[a[i] - min]++;
		}
		for (int i = 1; i < count.Length; i++) {
			count[i] += count[i - 1];
		}
		for (int i = a.Length - 1; i >= 0; i--) {
			output[count[a[i] - min] - 1] = a[i];
			count[a[i] - min]--;
		}
		for (int i = 0; i < a.Length; i++) {
			a[i] = output[i];
		}
	}
	static void printarray(int[] a)
	{
		for (int i = 0; i < a.Length; i++) {
			Console.Write(a[i] + " ");
		}
		Console.WriteLine();
	}

	public static void Main(string[] args)
	{
		int n = Convert.ToInt32(Console.ReadLine());
		int[] a = new int[n];
		for(int i=0;i<a.Length;i++)
		{
			a[i] = Convert.ToInt32(Console.ReadLine());
		}
		sort(a);
		printarray(a);
	}
}


