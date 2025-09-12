using getHashCode_equals.Entities;

namespace getHashCode_equals;

class Program
{
    static void Main(string[] args)
    {
        // string a = "Maria";
        // string b = "Alex";
        //
        // Console.WriteLine(a.Equals(b));
        //
        // string c = "Maria";
        // string d = "Maria";
        // Console.WriteLine(c.GetHashCode());
        // Console.WriteLine(d.GetHashCode());
        
        Client a = new Client { Nome = "Sergio", Email = "sergio@gmail.com"}; 
        Client b = new Client { Nome = "Erik", Email = "sergio@gmail.com"};

        // aqui é comparado o conteudo do objeto
        Console.WriteLine(a.Equals(b));

        //aqui é comparado a referência de memória
        Console.WriteLine(a == b);

        Console.WriteLine(a.GetHashCode());
        Console.WriteLine(b.GetHashCode());
    }
}