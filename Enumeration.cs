        using System;
        using System.Collections;

        class Program
        {
            static void Main(string[] args)
            {

            int[] numbers = { 1, 2, 3, 4, 5 };
        IEnumerator enumerator = numbers.GetEnumerator();

        while (enumerator.MoveNext())
        {
            Console.WriteLine(enumerator.Current);
        }

        List<string> fruits = new List<string> { "apple", "banana", "cherry" };
        IEnumerator<string> enumerator = fruits.GetEnumerator();

        while (enumerator.MoveNext())
        {
            Console.WriteLine(enumerator.Current);
        }

        LinkedList<int> list = new LinkedList<int>();
        list.AddLast(1);
        list.AddLast(2);
        list.AddLast(3);

        IEnumerator<int> enumerator = list.GetEnumerator();
        while (enumerator.MoveNext())
        {
           Console.WriteLine(enumerator.Current);
        }

        Queue<int> queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        IEnumerator enumerator = queue.GetEnumerator();
        while (enumerator.MoveNext())
        {
          Console.WriteLine(enumerator.Current);
        }

        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        IEnumerator enumerator = stack.GetEnumerator();
        while (enumerator.MoveNext())
        {
           Console.WriteLine(enumerator.Current);
        }

        Dictionary<string, int> ages = new Dictionary<string, int>
        {
            { "Alice", 25 },
            { "Bob", 30 },
            { "Charlie", 35 }
        };

        IEnumerator<KeyValuePair<string, int>> enumerator = ages.GetEnumerator();
        while (enumerator.MoveNext())
        {
            KeyValuePair<string, int> entry = enumerator.Current;
            string name = entry.Key;
            int age = entry.Value;
            Console.WriteLine($"{name} is {age} years old");
        }

            Hashtable hashtable = new Hashtable();
            hashtable.Add("apple", 5);
            hashtable.Add("banana", 2);
            hashtable.Add("orange", 3);

            IEnumerator enumerator = hashtable.GetEnumerator();
            while (enumerator.MoveNext())
            {
                HashtableEntry entry = (HashtableEntry)enumerator.Current;
                Console.WriteLine("Key: {0}, Value: {1}", entry.Key, entry.Value);
            }

        HashSet<string> set = new HashSet<string> { "apple", "banana", "cherry" };
        IEnumerator<string> enumerator = set.GetEnumerator();

        while (enumerator.MoveNext())
        {
           Console.WriteLine(enumerator.Current);
        }

            }
        }
