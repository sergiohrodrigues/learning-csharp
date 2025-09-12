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
        SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
        SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };
        
        //union
        SortedSet<int> c = new SortedSet<int>(a);
        c.UnionWith(b);
        printCollection(c);
        
        //intersection
        SortedSet<int> d = new SortedSet<int>(a);
        d.IntersectWith(b);
        printCollection(d);
        
        //difference
        SortedSet<int> e = new SortedSet<int>(a);
        e.ExceptWith(b);
        printCollection(e);
    }
    static void printCollection<T>(IEnumerable<T> collection) {
        foreach(T obj in collection) {
            Console.Write(obj + " ");
        }
        Console.WriteLine();
    }
}
