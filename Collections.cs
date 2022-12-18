using System;
using System.Collections;
using System.Collections.Generic;


public class main {

	static public void Main()
	{
		// Arrays
		// Arrays are static in size
		// Arrays are static in type 

		int[] Array = new int[]{1, 2, 3, 4, 5};
		for(int i=0;i<5;i++)
		{
			Console.Write(Array[i]+ " ");
		}
		Console.WriteLine();
		// Lists
		// Lists are dynamic in size
		// Lists are static in type 

		List<String> s = new List<String>();
		s.Add("Abrar");
		s.Add("Ahmed");
		foreach(string a in s)
		{
			Console.Write(a+ " ");
		}
		Console.WriteLine();

		// ArrayLists
		// ArrayLists are dynamic in size
		// ArrayLists are dynamic in type 

		ArrayList t = new  ArrayList();
		t.Add("Jahangeer");
		t.Add("Khan");
		foreach(string b in t)
		{
			Console.Write(b+ " ");
		}
		Console.WriteLine();


		// LinkedList  
		// LinkedList are dynamic in size
		// LinkedList are static in type 

		LinkedList<int> u = new LinkedList<int>();
		u.AddLast(30);
		u.AddLast(50);
		foreach(int c in u)
		{
			Console.Write(c+ " ");
		}
		Console.WriteLine();

		// Stacks 
		// Stacks are dynamic in size
		// Stacks are dynamic in type 

		Stack v = new Stack();
		v.Push("Ali");
		v.Push("Daniyal");
		foreach(string d in v)
		{
			Console.Write(d+ " ");
		}
		Console.WriteLine();

		// Queues 
		// Queues are dynamic in size
		// Queues are dynamic in type 

		Queue w = new Queue();
		w.Enqueue("Ayyan");
		w.Enqueue("Khan");
		foreach(string e in w)
		{
			Console.Write(e+ " ");
		}
		Console.WriteLine();


		// Dictionaries 
		// Dictionaries are dynamic in size
		// Dictionaries are static in type 

		Dictionary<String, String> x = new Dictionary<String, String>();
		x.Add("Mr", "Abrar");
		foreach(KeyValuePair<string, string> i in x)
		{
			Console.WriteLine("{0} {1}", i.Key, i.Value);
		}

		// Hashtables 
		// Hashtables are dynamic in size
		// Hashtables are dynamic in type 

		Hashtable y = new Hashtable();
		y.Add("Abrar", 22);
		foreach(DictionaryEntry i in y)
		{
			Console.WriteLine("{0} {1}", i.Key, i.Value);
		}

	}
}
