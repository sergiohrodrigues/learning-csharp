namespace Exercicio_proposto;

class Program
{
    static void Main(string[] args)
    {
        //Eu fiz
        // SortedSet nao adiciona valores duplicados, então perder informação se o mesmo aluno estiver em mais de um curso, conta apenas 1 vez..
        SortedSet<int> codigosAlunos = new SortedSet<int>();

        Console.Write("How many students for course A? ");
        int studentsA = int.Parse(Console.ReadLine());
        for (int i = 0; i < studentsA; i++)
        {
            codigosAlunos.Add(int.Parse(Console.ReadLine()));
        }
        
        Console.Write("How many students for course B? ");
        int studentsB = int.Parse(Console.ReadLine());
        for (int i = 0; i < studentsB; i++)
        {
            codigosAlunos.Add(int.Parse(Console.ReadLine()));
        }

        Console.Write("How many students for course C? ");
        int studentsC = int.Parse(Console.ReadLine());
        for (int i = 0; i < studentsC; i++)
        {
            codigosAlunos.Add(int.Parse(Console.ReadLine()));
        }

        Console.WriteLine("Total students: " + codigosAlunos.Count);
        
        //Professor fez
        HashSet<int> courseA = new HashSet<int>();
        HashSet<int> courseB = new HashSet<int>();
        HashSet<int> courseC = new HashSet<int>();

        Console.Write("How many students for course A? ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++) {
            int cod = int.Parse(Console.ReadLine());
            courseA.Add(cod);
        }

        Console.Write("How many students for course B? ");
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++) {
            int cod = int.Parse(Console.ReadLine());
            courseB.Add(cod);
        }

        Console.Write("How many students for course C? ");
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++) {
            int cod = int.Parse(Console.ReadLine());
            courseC.Add(cod);
        }

        HashSet<int> all = new HashSet<int>(courseA);
        all.UnionWith(courseB);
        all.UnionWith(courseC);
        Console.WriteLine("Total students: " + all.Count);
    }
}