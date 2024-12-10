namespace Assignment6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
			//         Queue<string> callers = new Queue<string>();

			//         callers.Enqueue("910-234-8767");
			//         callers.Enqueue("910-847-4748");
			//         callers.Enqueue("910-347-3486");
			//         callers.Enqueue("910-748-8560");
			//         callers.Enqueue("910-253-8999");

			//         Console.WriteLine("Callers in the queue:\n");

			//         foreach (string caller in callers)
			//         {
			//             Console.WriteLine("\t" + caller);
			//         }

			//         Console.WriteLine("\nDequeuing '{0}'", callers.Dequeue());
			//Console.WriteLine("Dequeuing '{0}'", callers.Dequeue());
			//Console.WriteLine("Dequeuing '{0}'", callers.Dequeue());
			//Console.WriteLine("Dequeuing '{0}'", callers.Dequeue());
			//Console.WriteLine("Dequeuing '{0}'", callers.Dequeue());
		
			LinkedList<string> callerQueue = new LinkedList<string>();

			callerQueue.AddLast("910-234-8767");
			callerQueue.AddLast("910-847-4748");
			callerQueue.AddLast("910-347-3486");
			callerQueue.AddLast("910-748-8560");
			callerQueue.AddLast("910-253-8999");

			Console.WriteLine("Callers in the queue:\n");

			foreach (string caller in callerQueue)
			{
				Console.WriteLine("\t" + caller);
			}

			Console.WriteLine("\nDequeuing callers:\n");

			while (callerQueue.Count > 0)
			{
				string currentCaller = callerQueue.First.Value;  // Get the first caller
				Console.WriteLine("Dequeuing '{0}'", currentCaller);
				callerQueue.RemoveFirst();
			}

			if (callerQueue.Count == 0)
			{
				Console.WriteLine("\nThe caller queue is empty.");
			}
		}
	}
}
