using System.Globalization;
using generics_restrictions.Entities;
using generics_restrictions.Services;

namespace generics_restrictions;

class Program
{
    static void Main(string[] args)
    {
        List<Product> list = new List<Product>();

        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] vector = Console.ReadLine().Split(',');
            string name = vector[0];
            double price = double.Parse(vector[1], CultureInfo.InvariantCulture);
            list.Add(new Product(name, price));
        }
        
        CalculationService calculationService = new CalculationService();

        Product max = calculationService.Max(list);

        Console.WriteLine("Max:");
        Console.WriteLine(max);
    }
}