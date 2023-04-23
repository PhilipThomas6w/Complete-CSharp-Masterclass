namespace LambdaExpressions;

public class Program
{
    // Define a delegate type called FilterDelegate that takes a person object and returns a bool
    // Recall that delegates should be declared at the top of the class

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

        //DisplayPeople("Kids:", people, IsMinor);
        //DisplayPeople("Adults:", people, IsAdult);
        //DisplayPeople("Seniors:", people, IsSenior);
        //Console.WriteLine();
        DisplayPeople("Using a predicate - People aged 20 to 30:", people, Aged20To30);

        #region Anonymous Methods

        // From here...

        FilterDelegate filter = delegate (Person p)
        {
            return p.Age >= 20 && p.Age <= 30;
        };

        DisplayPeople("Using a delegate - People aged 20 to 30:", people, filter);

        // to here, is the same as from here...

        DisplayPeople("Using an anonymous method - People aged 20 to 30:", people, delegate (Person p) { return p.Age >= 20 && p.Age <= 30; });

        // to here.

        #endregion

        #region Lambda Expressions

        DisplayPeople("Using a lambda expression - People aged 20 to 30:", people, p => p.Age >= 20 && p.Age <= 30);

        string searchKeyword = "I";

        // The lambda expression is much more concise than...
        DisplayPeople($"People who are older than 20 and whose name contains {searchKeyword}:", people, p => p.Name.Contains(searchKeyword.ToLower()) && p.Age > 20);


        // the lambda statement...
        DisplayPeople($"People who are older than 20 and whose name contains {searchKeyword}:", people, (p) =>
       {
           if (p.Name.Contains(searchKeyword.ToLower()) && p.Age > 20)
           {
               return true;
           }
           else { return false; }
       });



        #endregion

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

    //static bool IsMinor(Person p)
    //{
    //    return p.Age < 18;
    //}

    //static bool IsAdult(Person p)
    //{
    //    return p.Age >= 18;
    //}

    //static bool IsSenior(Person p)
    //{
    //    return p.Age >= 65;
    //}

    static bool Aged20To30(Person p)
    {
        return p.Age >= 20 && p.Age <= 30;
    }


    #endregion
}