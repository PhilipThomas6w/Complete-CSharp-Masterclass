namespace DelegatesDemo3;

public class Run
{
    public delegate float OperationDelegate(float a, float b);

    public static float Add(float a, float b)
    {
        return a + b;
    }

    public static float Subtract(float a, float b)
    {
        return a - b;
    }


    public static float Multiply(float a, float b)
    {
        return a * b;
    }

    public static float Divide(float a, float b)
    {
        return a / b;
    }

    public static float ApplyOperation(float a, float b, OperationDelegate operation)
    {
        float result = operation(a, b);
        return result;
    }

    public static string Operation(int userSelectedOperation)
    {
        switch (userSelectedOperation)
        {
            case (1):
                return "Addition";
                break;
            case (2):
                return "Subtraction";
                break;
            case (3):
                return "Multiplication";
                break;
            case (4):
                return "Division";
                break;
            default:
                return "Invalid selection.";

        }
    }

    public static void Main()
    {
        Console.WriteLine("Enter a number: ");
        string userInput1 = Console.ReadLine();
        float a = float.Parse(userInput1);
        Console.WriteLine("Enter another number: ");
        string userInput2 = Console.ReadLine();
        float b = float.Parse(userInput2);

        Console.WriteLine("Select the operation you want to perform: '1' for addition, '2' for subtraction, '3' for multiplication or '4' for division.");
        int userSelectedOperation = Int32.Parse(Console.ReadLine());
        string operation = Operation(userSelectedOperation);


        float result = ApplyOperation(a, b, operation switch
        {
            "Addition" => Add,
            "Subtraction" => Subtract,
            "Multiplication" => Multiply,
            "Division" => Divide,
            _ => null // Added a null case for invalid operations
        });

        if (result != null) // Check for null result
        {
            Console.WriteLine($"Result: {result}");
        }
        else
        {
            Console.WriteLine("Invalid operation selected.");
        }

    }
}