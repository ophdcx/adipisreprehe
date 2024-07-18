using System;

class Program
{
    // ------ Helper Methods ------
    
    static int Add(int a, int b)
    {
        return a + b;
    }

    static int Subtract(int a, int b)
    {
        return a - b;
    }

    static void Main()
    {
        int result1 = Add(5, 3);
        int result2 = Subtract(10, 4);

        Console.WriteLine($"Addition: {result1}");  // Output: Addition: 8
        Console.WriteLine($"Subtraction: {result2}");  // Output: Subtraction: 6
    }
}
