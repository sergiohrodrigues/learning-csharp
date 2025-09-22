using Comparison.Entities;

namespace Comparison;

class Program
{
    static void Main(string[] args)
    {
    //     Comparison<T> (System)
    //     https://msdn.microsoft.com/en-us/library/tfakywbh(v=vs.110).aspx
    
        // public delegate int Comparison<in T>(T x, T y);
        
        // Método Sort com Comparison<T> da classe List:
        // https://msdn.microsoft.com/en-us/library/w56d4y5z%28v=vs.110%29.aspx
    
    //      Resumo da aula
    //      public void Sort(Comparison<T> comparison)
    
    //     • Referência simples de método como parâmetro
    //     • Referência de método atribuído a uma variável tipo delegate
    //     • Expressão lambda atribuída a uma variável tipo delegate
    //     • Expressão lambda inline

        
        List<Product> list = new List<Product>();
        list.Add(new Product("TV", 900.00));
        list.Add(new Product("Notebook", 1200.00));
        list.Add(new Product("Tablet", 450.00));

        // Tipo delegate..
        // Comparison<Product> comp = CompareProducts;
        // list.Sort(comp);

        // expressao lambda atribuida a uma variavel tipo delegate
        // Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());

        // expressao lambda inline
        list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

        foreach (Product p in list)
        {
            Console.WriteLine(p);
        }
    }

    // static int CompareProducts(Product p1, Product p2) {
    //     return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
    // }
}