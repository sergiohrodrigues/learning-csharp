namespace getHashCode_equals;

class Program
{
    static void Main(string[] args)
    {
        string a = "Maria";
        string b = "Alex";

        Console.WriteLine(a.Equals(b));
        
        string c = "Maria";
        string d = "Maria";
        Console.WriteLine(c.GetHashCode());
        Console.WriteLine(d.GetHashCode());
    }
}