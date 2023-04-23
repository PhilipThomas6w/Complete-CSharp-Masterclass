namespace Coding.Exercise;

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

    public static float ApplyOperation(float a, float b, OperationDelegate oper)
    {
        float result = oper(a, b);
        return result;
    }

    public static void Main()
    {
        Console.WriteLine("Enter a number: ");
        string userInput1 = Console.ReadLine();
        float a = float.Parse(userInput1);
        Console.WriteLine("Enter another number: ");
        string userInput2 = Console.ReadLine();
        float b = float.Parse(userInput2);
      
        Console.WriteLine(ApplyOperation(a,b, Multiply));

    }
}