namespace CreatingDelegates;

class Program
{
    // In this lesson, we will create our own delegate.
    // 1. Define a delegate type called FilterDelegate that takes a person object and returns a bool
    // (Recall that delegates should be declared at the top of the class body)

    public delegate bool FilterDelegate(Person p);

    static void Main()
    {
        // Instantiate 4 people i.e., 4 person objects

        Person p1 = new Person() { Name = "Aiden", Age = 41 };
        Person p2 = new Person() { Name = "Sif", Age = 69 };
        Person p3 = new Person() { Name = "Walter", Age = 12 };
        Person p4 = new Person() { Name = "Anatoli", Age = 25 };

        // Add the objects to a list named "people"

        List<Person> people = new List<Person>() { p1, p2, p3, p4 };

        DisplayPeople("Kids:", people, IsMinor);
        DisplayPeople("Adults:", people, IsAdult);
        DisplayPeople("Seniors:", people, IsSenior);

    }

   static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
    {
        Console.WriteLine(title);

        foreach (Person p in people)
        {
            if (filter(p))
            {
                Console.WriteLine($"{p.Name}, {p.Age} years old");
            }
        }
    }

    #region FILTERS

    static bool IsMinor(Person p)
    {
        return p.Age < 18;
    }
    
    static bool IsAdult(Person p)
    {
        return p.Age >= 18;
    }
    
    static bool IsSenior(Person p)
    {
        return p.Age >= 65;
    }


    #endregion
}