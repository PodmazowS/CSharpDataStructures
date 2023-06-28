namespace DataStructures;

public class LinkedList
{
    public void LinkedListOperations()
    {
        LinkedList<string> linkedList = new LinkedList<string>();
        
        Console.WriteLine("Initial elements in list:");
        
        linkedList.AddLast("Apple");
        linkedList.AddLast("Banana");
        linkedList.AddLast("Orange");

        foreach (string element in linkedList)
        {
            Console.WriteLine(element);
        }
        
        Console.WriteLine("\n");
        Console.WriteLine("Find first and last element in list:");

        string firstElement = linkedList.First.Value;
        string lastElement = linkedList.Last.Value;
        
        Console.WriteLine($"First element in list is {firstElement}");
        Console.WriteLine($"Last element in list is {lastElement}");

        linkedList.AddAfter(linkedList.First, "Mango");
        linkedList.AddBefore(linkedList.Last, "Grapes");
        
        linkedList.RemoveFirst();
        linkedList.RemoveLast();
        
        Console.WriteLine("\n");
        Console.WriteLine("Elements after change:");

        foreach (string element in linkedList)
        {
            Console.WriteLine(element);
        }
    }
}