using System;

namespace BubbleSort {

	class main {
		static void Main(string[] args) {

			int n = Convert.ToInt32(Console.ReadLine());

			int[] a= new int[n];

			for(int i=0;i<n;i++)
			{
				a[i] = Convert.ToInt32(Console.ReadLine());
			}

			int temp;
			for (int j = 0; j <= n - 2; j++) {
				for (int i = 0; i <= n - 2; i++) {
					if (a[i] > a[i + 1]) {
						temp= a[i + 1];
						a[i + 1] = a[i];
						a[i] = temp;
					}
				}
			}
			Console.Write("The sorted array is: ");
			foreach (int i in a)
			{
				Console.Write(i + " ");
			}
			Console.WriteLine();
		}
	}
}
