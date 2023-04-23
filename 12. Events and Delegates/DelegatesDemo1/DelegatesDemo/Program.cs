namespace DelegatesDemo;

internal class Program
{
    static void Main()
    {
        // Declare a list of names and initialise

        List<string> names = new() { "Aiden", "Sif", "Walter", "Anatoli" };

        // Print the names before we run the RemoveAll method.
        
        Console.WriteLine("---before---");
        
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

        // Now we call the RemoveAll method. The RemoveAll method takes a predicate (i.e., a type of delegate) as an argument; in this case, we will pass a method we've defined below, named Filter, as the predicate. The return type of a predicate is a bool.
        
        names.RemoveAll(Filter);    // Removes each element in names for which Filter returns true.

        // Print the names after we run the RemoveAll method.
        
        Console.WriteLine("---after---");

        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

    }

    static bool Filter(string s)
    {
        return s.Contains("i"); // If string s contains "i", return true, else false.
    }

}