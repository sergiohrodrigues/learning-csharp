using Func.Entities;

namespace Func;

class Program
{
    static void Main(string[] args)
    {
        //• Representa um método que recebe zero ou mais argumentos, e retorna um valor
        //• https://msdn.microsoft.com/en-us/library/bb534960%28v=vs.110%29.aspx
        
        // public delegate TResult Func<out TResult>();
        // public delegate TResult Func<in T, out TResult>(T obj);
        // public delegate TResult Func<in T1, in T2, out TResult>(T1 arg1, T2 arg2);
        // public delegate TResult Func<in T1, in T2, in T3, out TResult>(T1 arg1, T2 arg2, T3 arg3);
        // (16 sobrecargas)
        
        List<Product> list = new List<Product>();
        list.Add(new Product("Tv", 900.00));
        list.Add(new Product("Mouse", 50.00));
        list.Add(new Product("Tablet", 350.50));
        list.Add(new Product("HD Case", 80.90));

        // Delegate
        //Func<Product, string> func = NameUpper;
        
        // Expressão Lambda
        Func<Product, string> func = p => p.Name.ToUpper();
        
        //List<string> result = list.Select(NameUpper).ToList();
        //List<string> result = list.Select(func).ToList();
        //List<string> result = list.Select(func).ToList();
        
        // expressão lambida inline
        List<string> result = list.Select(p => p.Name.ToUpper()).ToList();

        foreach (var s in result)
        {
            Console.WriteLine(s);
        }
    }

    static string NameUpper(Product p)
    {
        return p.Name.ToUpper();
    }
}