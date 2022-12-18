import java.io.*;
import java.util.*;

public class Main {

	public static void main(String[] args)
	{
		// Arrays
		// Arrays are static in size
		// Arrays are static in type 

		int[] Array = {1, 2, 3, 4, 5};
		for(int i=0;i<Array.length;i++)
		{
			System.out.print(Array[i]+ " ");
		}
		System.out.println();

		// Lists
		// Lists are dynamic in size
		// Lists are static in type 

		List<String> s = new ArrayList<String>();
		s.add("Abrar");
		s.add("Ahmed");
		System.out.print(s+ " ");
		System.out.println();

		// ArrayLists
		// ArrayLists are dynamic in size
		// ArrayLists are dynamic in type 

		ArrayList t = new  ArrayList();
		t.add("Jahangeer");
		t.add("Khan");
		System.out.print(t+ " ");
		System.out.println();	


		// LinkedList  
		// LinkedList are dynamic in size
		// LinkedList are static in type 

		LinkedList<Integer> u = new LinkedList<Integer>();
		u.add(30);
		u.add(50);
		System.out.print(u+ " ");
		System.out.println();

		// Set 
		// Sets are dynamic in size
		// Sets are dynamic in type 

		Set h = new HashSet();
		h.add("Haris");
		h.add(10);
		System.out.print(h+" ");
		System.out.println();

		// TreeSet 
		// TreeSets are dynamic in size
		// TreeSets are static in type 

		TreeSet<String> l = new TreeSet<String>();  
		l.add("Ali");  
		l.add("Muzzamil");  
		System.out.print(l+ " ");
		System.out.println();

		// Stacks 
		// Stacks are dynamic in size
		// Stacks are dynamic in type 

		Stack v = new Stack();
		v.push("Daniyal");
		v.push("Ali");
		System.out.print(v+ " ");
		System.out.println();

		// Queues 
		// Queues are dynamic in size
		// Queues are dynamic in type 

		Queue w = new PriorityQueue();
		w.add("Ayyan");
		w.add("Khan");
		System.out.print(w+ " ");
		System.out.println();

		Queue z = new LinkedList();
		z.add("Arman");
		z.add("Khan");
		System.out.print(z+ " ");
		System.out.println();


		// Hashtables 
		// Hashtables are dynamic in size
		// Hashtables are dynamic in type 

		Hashtable y = new Hashtable();
		y.put("Abrar ", 22);
		y.put("jahangeer ", 20);
		System.out.println(y);

		// HashMap 
		// HashMap are dynamic in size
		// HashMap are dynamic in type 
		HashMap k = new HashMap();
		k.put("Sami ", 26);
		k.put("Zain ", 25);
		System.out.println(k);

	}
}
