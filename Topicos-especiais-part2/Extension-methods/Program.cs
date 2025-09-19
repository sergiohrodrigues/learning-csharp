namespace Extension_methods;

class Program
{
    static void Main(string[] args)
    {
        DateTime dt = new DateTime(2025, 09, 19, 2, 10, 45);
        Console.WriteLine(dt.ElapsedTime());

        String s1 = "Good morning dear students!";
        Console.WriteLine(s1.Cut(10));
    }
}