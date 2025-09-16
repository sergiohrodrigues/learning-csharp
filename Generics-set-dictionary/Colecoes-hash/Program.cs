using Colecoes_hash.Entities;
using Point = Colecoes_hash.Entities.Point;

namespace Colecoes_hash;

class Program
{
    static void Main(string[] args)
    {
         HashSet<string> set = new HashSet<string>();
        
         set.Add("Maria");
         set.Add("Alex");
        
         // aqui primeiro ele usa o GetHashCode e depois o Equals, porque o tipo string tem eles implementados..
         Console.WriteLine(set.Contains("Maria"));
        
         HashSet<Product> a = new HashSet<Product>();
         a.Add(new Product("TV", 900.0));
         a.Add(new Product("Notebook", 1200.0));
        
         HashSet<Point> b = new HashSet<Point>();
         b.Add(new Point(3, 4));
         b.Add(new Point(5, 10));
        
         Product prod = new Product("Notebook", 1200.0);
        
         // aqui vai dar false se não tiver implementado getHashCode e Equals, porque um classe é comparada por referência e nao por valor,
             // só vai dar true se estiver implementado o getHashCode e Equals.
         Console.WriteLine(a.Contains(prod));
        
         Point point = new Point(5, 10);
        
         // aqui da true, porque struct é comparado por valor e não por referência..
         Console.WriteLine(b.Contains(point));
    }
}