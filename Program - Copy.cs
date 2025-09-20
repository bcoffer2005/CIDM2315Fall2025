namespace Homework4;

class Program
{
    static int LargestNumber(int a, int b)
    {
        if (a > b)
            return a;
        else
            return b;
    }

    static void Main(string[] args)
    {
        int a = 3, b = 5;

        // Call the method
        int result = LargestNumber(a, b);

        // Print the result
        Console.WriteLine("a = {0}; b = {1}", a, b);
        Console.WriteLine("The largest number is: {0}", result);
    }
}
