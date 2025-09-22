using Predicate.Entities;

namespace Predicate;

class Program
{
    static void Main(string[] args)
    {
        // Representa um método que recebe um objeto do tipo T e retorna um valor booleano
        //     • https://msdn.microsoft.com/en-us/library/bfcke1bz%28v=vs.110%29.aspx

        // public delegate bool Predicate<in T>(T obj);
    
        List<Product> list = new List<Product>();
        list.Add(new Product("Tv", 900.00));
        list.Add(new Product("Mouse", 50.00));
        list.Add(new Product("Tablet", 350.50));
        list.Add(new Product("HD Case", 80.90));

        //list.RemoveAll(p => p.Price >= 100.0);
        list.RemoveAll(ProductTeste);
        
        foreach (Product p in list) {
            Console.WriteLine(p);
        }
    }

    public static bool ProductTeste(Product p)
    {
        return p.Price >= 100.0;
    }
}