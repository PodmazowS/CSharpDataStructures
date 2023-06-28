// See https://aka.ms/new-console-template for more information

using DataStructures;

Console.WriteLine("Stack:");
Stack stack = new Stack();
stack.StackOperations();

Console.WriteLine("----------------------");

Console.WriteLine("LinkedList:");
LinkedList linkedList = new LinkedList();
linkedList.LinkedListOperations();

Console.WriteLine("----------------------");
Console.WriteLine("Queue:");
Queue queue = new Queue();
queue.QueueOperations();

Console.WriteLine("----------------------");
Console.WriteLine("Dictionary:");
Dictionary dictionary = new Dictionary();
dictionary.DictionaryOperations();