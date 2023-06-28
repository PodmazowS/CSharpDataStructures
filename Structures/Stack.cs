namespace DataStructures;

public class Stack
{
    public void StackOperations()
    {
        Stack<int> numberStack = new Stack<int>();
        
        numberStack.Push(10);
        numberStack.Push(20);
        numberStack.Push(30);

        int topNum = numberStack.Pop();
        Console.WriteLine(topNum);

        int secondNum = numberStack.Pop();
        Console.WriteLine(secondNum);

        int lastNum = numberStack.Pop();
        Console.WriteLine(lastNum);

        bool isEmpty = numberStack.Count == 0;
        Console.WriteLine(isEmpty);
    }
}