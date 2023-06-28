namespace DataStructures;

public class Queue
{
    public void QueueOperations()
    {
        Queue<string> queue = new Queue<string>();
        
        queue.Enqueue("Apple");
        queue.Enqueue("Orange");
        queue.Enqueue("Banana");
        
        //Get first element in queue
        string firstElement = queue.Peek();
        Console.WriteLine($"First element in queue is: {firstElement}");
        
        //Get last element in queue
        string[] queueArray = queue.ToArray();
        if (queueArray.Length > 0)
        {
            string lastElement = queueArray[queueArray.Length - 1];
            Console.WriteLine($"Last element in queue is: {lastElement}");
        }
        
        //Removing elements
        Console.WriteLine("\n");
        string removedElement = queue.Dequeue();
        Console.WriteLine($"Removed element is: {removedElement}");
        
        //Iterating over the elements
        Console.WriteLine("\n");
        Console.WriteLine("Elements:");
        foreach (string element in queueArray)
        {
            Console.WriteLine(element);
        }



    }
}