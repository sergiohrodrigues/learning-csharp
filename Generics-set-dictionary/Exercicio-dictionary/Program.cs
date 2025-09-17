namespace Exercicio_dictionary;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> set = new Dictionary<string, int>();
        
        Console.Write("Enter file full path: ");
        string path = Console.ReadLine();
        try {
            using (StreamReader sr = File.OpenText(path)) {
                while (!sr.EndOfStream) {
                    string[] line = sr.ReadLine().Split(',');
                    string name = line[0];
                    int valor = int.Parse(line[1]);

                    if (set.ContainsKey(name))
                        set[name] += valor;
                    else
                        set[name] = valor;
                }

                foreach (KeyValuePair<string, int> item in set)
                {
                    Console.WriteLine(item.Key + ": " + item.Value);
                }
            }
        }
        catch (IOException e) {
            Console.WriteLine(e.Message);
        }
    }
}