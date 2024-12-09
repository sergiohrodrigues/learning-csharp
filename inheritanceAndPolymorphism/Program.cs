using System.Drawing;
using System.Globalization;
using System.Transactions;
using inheritanceAndPolymorphism.Entities;
using inheritanceAndPolymorphism.Entities_2;
using inheritanceAndPolymorphism.Entities_4;
using inheritanceAndPolymorphism.Entities_4.Enums;
using inheritanceAndPolymorphism.Entities_5;
using inheritanceAndPolymorphism.EntitiesExercice1;
using inheritanceAndPolymorphism.EntitiesExercice2;
using Color = inheritanceAndPolymorphism.Entities_4.Enums.Color;
using Rectangle = inheritanceAndPolymorphism.Entities_4.Rectangle;

//BusinessAccount account = new BusinessAccount(1080, "Bob Brown", 100.0, 500.0);

//Console.WriteLine(account.Balance);

//account.Balance = 200.0;

//Account acc = new Account(1001, "Alex", 0.0);
//BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

// UPCASTING
/*Account acc1 = bacc;
Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);*/

// DOWNCASTING
/*testar somente quando for necessario, (inseguro)


BusinessAccount acc4 = (BusinessAccount)acc2;
acc4.Loan(100.0);
acc2.Loan(100.0);

BusinessAccount acc5 = (BusinessAccount)acc3;
if (acc3 is BusinessAccount)
{
    //BusinessAccount acc5 = (BusinessAccount)acc3;
    BusinessAccount acc5 = acc3 as BusinessAccount;
    acc5.Loan(200.0);
    Console.WriteLine("Loan!");
}

if (acc3 is SavingsAccount)
{
    //BusinessAccount acc5 = (BusinessAccount)acc3;
    //teste
    SavingsAccount acc5 = acc3 as SavingsAccount;
    acc5.UpdateBalance();
    Console.WriteLine("Update!");
}*/



//Sobreposições, palavra virtual, override e base
/*Account acc1 = new Account(1001, "Alex", 500.0);
Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

acc1.WithDraw(10.0);
acc2.WithDraw(10.0);

Console.WriteLine(acc1.Balance);
Console.WriteLine(acc2.Balance);*/



// EXERCICIO FICCAÇÃO #1
/*List<Employee> list = new List<Employee>();

Console.Write("Enter the number of employess: ");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Employee #{i} data:");
    Console.Write("Outsourced (y/n)? ");
    char emp = char.Parse(Console.ReadLine());

    if(emp != 'y' && emp != 'n')
    {
        Console.WriteLine("Por favor digite 'y' ou 'n'.");
        Console.Write($"Employee #{i} data: ");
        emp = char.Parse(Console.ReadLine());
    }

    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Hours: ");
    int hours = int.Parse(Console.ReadLine());
    Console.Write("Value per hour: ");
    double valuePorHour = double.Parse(Console.ReadLine());
    if(emp == 'y')
    {
        Console.Write("Additional charge: ");
        double addCharge = double.Parse(Console.ReadLine());
        list.Add(new OutsourcedEmployee(name, hours, valuePorHour, addCharge));
    } else
    {
        list.Add(new Employee(name, hours, valuePorHour));
    }

}
    Console.WriteLine("PAYMENTS:");
    foreach(Employee e in list)
    {
        Console.WriteLine($"{e.Name} - $ {e.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
    }*/



// EXERCICIO FICCAÇÃO #2
/*List<Product> p = new List<Product>();

Console.Write("Enter the number of products: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Product #{i} data:");
    Console.Write("Common, used or imported (c/u/i)? ");
    string prod = Console.ReadLine();
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    if(prod == "c")
    {
        p.Add(new Product(name, price));
    } else if(prod == "i")
    {
        Console.Write("Customs fee: ");
        double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        p.Add(new ImportedProduct(name, price, fee));
    } else if(prod == "u")
    {
        Console.Write("Manufacture Date (DD/MM/YYYY): ");
        DateTime date = DateTime.Parse(Console.ReadLine());
        p.Add(new UsedProduct(name, price, date));
    }
}

Console.WriteLine();
Console.WriteLine("PRICE TAGS: ");
foreach(Product i in p)
{
    Console.WriteLine(i.PriceTag());
}*/



// CLASSES ABSTRATAS
/*Account acc1 = new Account(1001, "Alex", 20.0);
List<Account> list = new List<Account>();

list.Add(new BusinessAccount(1001, "Sergio", 500.0, 0.01));
list.Add(new SavingsAccount(1002, "Erik", 500.0, 400.0));
list.Add(new SavingsAccount(1003, "Joao", 500.0, 0.01));
list.Add(new BusinessAccount(1004, "Caio", 500.0, 500.0));

double sum = 0.0;

foreach (Account acc in list)
{
    sum += acc.Balance;
}

Console.WriteLine("Total: " + sum.ToString("F2", CultureInfo.InvariantCulture));

foreach (Account acc in list)
{
    acc.WithDraw(10.0);
}

foreach (Account acc in list)
{
    Console.WriteLine($"Updated balance for account {acc.Number}: {acc.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
}*/



// MÉTODOS ABSTRATOS
/*List<Shape> shapes = new List<Shape>();

Console.Write("Enter the number of shapes: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1;  i <= n; i++)
{
    Console.WriteLine($"Shape #{i} data: ");
    Console.Write("Rectangle or Circle (r/c)? ");
    char r = char.Parse( Console.ReadLine());
    Console.Write("Color (Black/Blue/Red): ");
    Color color = Enum.Parse<Color>(Console.ReadLine());
    if(r == 'r')
    {
        Console.Write("Width: ");
        double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("height: ");
        double height= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        shapes.Add(new Rectangle(color, width, height));
    } else if(r == 'c')
    {
        Console.Write("Radius: ");
        double radius = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture);
        shapes.Add(new Circle(color, radius));
    }
}

Console.WriteLine();
Console.WriteLine("SHAPE AREAS: ");
foreach (Shape shape in shapes)
{
    Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
}*/



// EXERCICIO DE FIXAÇÃO
/*List<TaxPayer> list = new List<TaxPayer>();

Console.Write("Enter the number of tax payers: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1;  i <= n; i++)
{
    Console.WriteLine($"Tax payer #{i} data: ");
    Console.Write("Individual or company (i/c)? ");
    char r = char.Parse( Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Anual Income: ");
    double anual= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    if(r == 'i')
    {
        Console.Write("Health expenditures: ");
        double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        list.Add(new Individual(name, anual, health));
    } else if(r == 'c')
    {
        Console.Write("Number of employees: ");
        int employees= int.Parse(Console.ReadLine());
        list.Add(new Company(name, anual, employees));
    }
}

Console.WriteLine();
Console.WriteLine("TAXES PAID: ");
foreach (TaxPayer tax in list)
{
    Console.WriteLine($"{tax.Name}: $ {tax.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
}

double total = 0.0;

foreach (TaxPayer tax in list)
{
    total += tax.Tax();
}

Console.WriteLine($"TOTAL TAXES: $ {total.ToString("F2", CultureInfo.InvariantCulture)}");
*/