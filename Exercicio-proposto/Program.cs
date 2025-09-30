// See https://aka.ms/new-console-template for more information

using System.Globalization;
using Exercicio_proposto.Entities;



    Console.Write("Enter full file path: ");
    string path = Console.ReadLine();
    Console.Write("Digite um valor: ");
    double valorUsuario = double.Parse((Console.ReadLine()));

    List<Employee> list = new List<Employee>();

    try
    {
        using (StreamReader sr = File.OpenText(path))
        {
            while (!sr.EndOfStream)
            {
                string[] fields = sr.ReadLine().Split(',');
                string name = fields[0];
                string email = fields[1];
                double price = double.Parse(fields[2], CultureInfo.InvariantCulture);
                list.Add(new Employee(name, email, price));
            }
        }

        Console.WriteLine("Email of people whose salary is more than " +
                          valorUsuario.ToString("F2", CultureInfo.InvariantCulture));

        var emails = list.Where(p => p.Salary > valorUsuario).OrderBy(p => p.Email).Select(p => p.Email);
        foreach (var p in emails)
        {
            Console.WriteLine(p);
        }

        var sum = list.Where(p => p.Name[0] == 'M').Select(p => p.Salary).Sum();
        Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sum);
    }
    catch (Exception e)
    {
        Console.WriteLine("An error occurred");
        Console.WriteLine(e.Message);
    }
    
    //Resolvido pelo professor

    // Console.Write("Enter full file path: ");
    // string path2 = Console.ReadLine();
    // Console.Write("Enter salary: ");
    // double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    //
    // List<Employee> list2 = new List<Employee>();
    //
    // try {
    //     using (StreamReader sr = File.OpenText(path2)) {
    //         while (!sr.EndOfStream) {
    //             string[] fields = sr.ReadLine().Split(',');
    //             string name = fields[0];
    //             string email = fields[1];
    //             double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
    //             list2.Add(new Employee(name, email, salary));
    //         }
    //
    //         var emails = list2.Where(obj => obj.Salary > limit).OrderBy(obj => obj.Email).Select(obj => obj.Email);
    //
    //         var sum = list2.Where(obj => obj.Name[0] == 'M').Sum(obj => obj.Salary);
    //
    //         Console.WriteLine("Email of people whose salary is more than " + limit.ToString("F2", CultureInfo.InvariantCulture));
    //         foreach (string email in emails) {
    //             Console.WriteLine(email);
    //         }
    //
    //         Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sum.ToString("F2", CultureInfo.InvariantCulture));
    //     }
    // }
    // catch (IOException e) {
    //     Console.WriteLine("An error occurred");
    //     Console.WriteLine(e.Message);
    // }