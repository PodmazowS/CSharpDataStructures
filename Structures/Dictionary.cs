namespace DataStructures;

public class Dictionary
{
    public void DictionaryOperations()
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        
        //Adding values to dictionary
        dictionary.Add("key1", "cat");
        dictionary.Add("key2", "dog");
        dictionary.Add("key3", "monkey");
        Console.WriteLine("Dictionary elements:");
        Console.WriteLine(dictionary["key1"]);
        Console.WriteLine(dictionary["key2"]);
        Console.WriteLine(dictionary["key3"]);
        
        Console.WriteLine("\n");
        //Accessing value by key 
        string value1 = dictionary["key1"];
        Console.WriteLine($"First value in dictionary is: {value1}");

        //Check if dictionary contains key
        bool containsKey = dictionary.ContainsKey("key2");
        Console.WriteLine($"Are dictionary contains key2? {containsKey}");

        //Removing element from dictionary
        dictionary.Remove("key3");
        
        



    }
}