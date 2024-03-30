namespace OOP_Assignment__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x <= 100; x++)
            {
                if (x % 15 == 0)
                {
                    Console.WriteLine("Hello, Goodbye!");
                }
                else if (x % 3 == 0)
                {
                    Console.WriteLine("Hello!");
                }
                else if (x % 5 == 0)
                {
                    Console.WriteLine("Goodbye!");
                }
                else
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}