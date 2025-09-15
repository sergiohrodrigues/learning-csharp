using HashSet_SortedSet.Entities;

namespace HashSet_SortedSet;

class Program
{
    static void Main(string[] args)
    {
        // Alguns métodos importantes
        //• Add
        //• Clear • Contains
        //• UnionWith(other) - operação união: adiciona no conjunto os elementos do outro conjunto, sem repetição
        //• IntersectWith(other) - operação interseção: remove do conjunto os elementos não contidos em other
        //• ExceptWith(other) - operação diferença: remove do conjunto os elementos contidos em other
        //• Remove(T)
        //• RemoveWhere(predicate)
            
        //**********HASHSET**************
        // HashSet<string> set = new HashSet<string>();
        //
        // set.Add("TV");
        // set.Add("Notebook");
        // set.Add("Tablet");
        //
        // Console.WriteLine(set.Contains("Notebook"));
        //
        // // Aqui não pode ser usado "for" pois o HashSet não guarda posição.. não consegue fazer set[1] por exemplo.
        // foreach (String p in set) {
        //     Console.WriteLine(p);
        // }
        
        
        //*************SORTEDSET*****************
        // SortedSet mantem os dados ordenados..
        // SortedSet<int> a = n



        //**************Como coleções hash comparar igualdade******************
        // HashSet<string> set = new HashSet<string>();
        //
        // set.Add("Maria");
        // set.Add("Alex");
        //
        // // aqui primeiro ele usa o GetHashCode e depois o Equals, porque o tipo string tem eles implementados..
        // Console.WriteLine(set.Contains("Maria"));
        
        // HashSet<Product> a = new HashSet<Product>();
        // a.Add(new Product("TV", 900.0));
        // a.Add(new Product("Notebook", 1200.0));
        //
        // HashSet<Point> b = new HashSet<Point>();
        // b.Add(new Point(3, 4));
        // b.Add(new Point(5, 10));
        //
        // Product prod = new Product("Notebook", 1200.0);
        //
        // // aqui vai dar false se não tiver implementado getHashCode e Equals, porque um classe é comparada por referência e nao por valor,
        //     // só vai dar true se estiver implementado o getHashCode e Equals.
        // Console.WriteLine(a.Contains(prod));
        //
        // Point point = new Point(5, 10);
        //
        // // aqui da true, porque struct é comparado por valor e não por referência..
        // Console.WriteLine(b.Contains(point));
        
        
        
        //*************Exercicios************
        
        HashSet<LogRecord> set = new HashSet<LogRecord>();

        Console.Write("Enter file full path: ");
        string path = Console.ReadLine();
        try {
            using (StreamReader sr = File.OpenText(path)) {
                while (!sr.EndOfStream) {
                    string[] line = sr.ReadLine().Split(' ');
                    string name = line[0];
                    DateTime instant = DateTime.Parse(line[1]);
                    set.Add(new LogRecord { Username = name, Instant = instant });
                }

                Console.WriteLine("Total users: " + set.Count);
            }
        }
        catch (IOException e) {
            Console.WriteLine(e.Message);
        }
        
    }
    static void printCollection<T>(IEnumerable<T> collection) {
        foreach(T obj in collection) {
            Console.Write(obj + " ");
        }
        Console.WriteLine();
    }
}
