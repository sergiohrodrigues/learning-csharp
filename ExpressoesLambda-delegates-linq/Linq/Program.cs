namespace Linq;

class Program
{
    static void Main(string[] args)
    {
        // LINQ - Language Integrated Query
        //     • É um conjunto de tecnologias baseadas na integração de funcionalidades de consulta diretamente na linguagem C#
        //     • Operações chamadas diretamente a partir das coleções
        //     • Consultas são objetos de primeira classe
        //     • Suporte do compilador e IntelliSense da IDE
        
        //     • Namespace: System.Linq
        
        //     • Possui diversas operações de consulta, cujos parâmetros tipicamente são expressões lambda ou expressões de sintaxe similar à SQL
        
        //     • Referência:
        //     • https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/index
        
        // Três passos
        //     • Criar um data source (coleção, array, recurso de E/S, etc.)
        //     • Definir a query
        //     • Executar a query (foreach ou alguma operação terminal)

        // Datasource => Query => Execution

        // Specify the data source.
        int[] numbers = new int[] { 2, 3, 4, 5 };

        // Define the query expression.
        IEnumerable<int> result = numbers
            .Where(x => x % 2 == 0)
            .Select(x => 10 * x);

        // Execute the query.
        foreach (int x in result) {
            Console.WriteLine(x);
        }
        
        // Operações do LINQ
        //     • Filtering: Where, OfType
        //     • Sorting: OrderBy, OrderByDescending, ThenBy, ThenByDescending, Reverse
        //     • Set: Distinct, Except, Intersect, Union
        //     • Quantification: All, Any, Contains
        //     • Projection: Select, SelectMany
        //     • Partition: Skip, Take
        //     • Join: Join, GroupJoin
        //     • Grouping: GroupBy
        //     • Generational: Empty
        //     • Equality: SequenceEquals
        //     • Element: ElementAt, First, FirstOrDefaultLast, LastOrDefault, Single, SingleOrDefault
        //     • Conversions: AsEnumerable, AsQueryable
        //     • Concatenation: Concat
        //     • Aggregation: Aggregate, Average, Count, LongCount, Max, Min, Sum
    }
}